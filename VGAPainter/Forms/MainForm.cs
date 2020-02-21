using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VGAPainter.Data;
using VGAPainter.Importers;

namespace VGAPainter.Forms
{
    public enum DrawMode
    {
        Draw,
        Fill,
        Picker
    }

    public partial class MainForm : Form
    {
        // VGA palette
        private Palette palette;
        private CharBitmap bitmap = new CharBitmap(16, 16);

        // canvas
        private Bitmap canvas;
        private int zoom = 5;

        // mouse actions
        private bool mouseDraw = false;
        private DrawMode drawMode;

        // user action history stacks
        private Stack<HistoryEvent> undoStack = new Stack<HistoryEvent>();
        private Stack<HistoryEvent> redoStack = new Stack<HistoryEvent>();

        // opened files' filename and status
        string openFileName;
        bool openFileImported = false;
        bool openFileDirty = false;

        // when the user MUST save as...
        bool mustSaveAs = false;    // (this is used for requesting save as)
        bool MustSaveAs
        {
            get
            {
                bool saveAs = OpenFileName == null | OpenFileImported | mustSaveAs;
                if (mustSaveAs) mustSaveAs = false;
                return saveAs;
            }
            set => mustSaveAs = value;
        }

        public string OpenFileName { get => this.openFileName; private set { this.openFileName = value; windowTitle(); } }
        public bool OpenFileImported { get => this.openFileImported; private set { this.openFileImported = value; windowTitle(); } }
        public bool OpenFileDirty { get => this.openFileDirty; private set { this.openFileDirty = value; windowTitle(); } }

        // temporary import
        BackgroundWorker importer = new BackgroundWorker();

        public MainForm()
        {
            palette = Palette.VGA;
            InitializeComponent();

            ColorSelector_Update();

            // a few UI things
            this.statusMode.Text = drawMode.ToString();
            FullRedraw();
            UpdateStackButtons();

            // set the filename (and titlebar)
            this.OpenFileName = null;
        }

        void ColorSelector_Update()
        {
            // 
            while (colorSelector.Items.Count > 0)
                colorSelector.Items.RemoveAt(0);

            // populate list with colours
            ImageList imgList = new ImageList();
            colorSelector.LargeImageList = imgList;
            colorSelector.SmallImageList = imgList;
            for (int i = 0; i < Palette.Length; i++)
            {
                Color color = palette[i];
                Bitmap bm = new Bitmap(16, 16);
                for (int y = 0; y < 16; y++)
                    for (int x = 0; x < 16; x++)
                        bm.SetPixel(x, y, color);

                ListViewItem listItem = new ListViewItem(i.ToString(), i);
                listItem.SubItems.Add(String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B));

                colorSelector.Items.Add(listItem);
                imgList.Images.Add(bm);
            }

            FullRedraw();
        }

        private void ShowPalette_Click(object sender, EventArgs e)
        {
            // candidate for removal

            bitmap = new CharBitmap(16, Palette.Length / 16);

            for (int i = 0; i <= byte.MaxValue; i++)
            {
                bitmap.Data[i] = (byte)i;
            }

            // clear the history stacks
            undoStack.Clear();
            redoStack.Clear();

            FullRedraw();
        }

        #region Bitmap rendering

        /// <summary>
        /// Renders the bitmap for modern screens
        /// </summary>
        private Bitmap RenderBitmap(int scale, bool grid)
        {
            if (scale <= 0) return null;

            // create .NET bitmap
            Bitmap bm = new Bitmap(bitmap.Width * scale, bitmap.Height * scale);

            // copy the pixels
            for (int y = 0; y < bm.Height; y += scale)
                for (int x = 0; x < bm.Width; x += scale)
                {
                    Color pixel = palette[bitmap.Data[y / scale * bitmap.Width + (x / scale)]];
                    for (int py = 0; py < scale; py++)
                        for (int px = 0; px < scale; px++)
                            bm.SetPixel(x + px, y + py, pixel);
                }

            // draw a grid
            if (grid && scale > 1)
            {
                Color gridColor = Color.Gray;
                for (int x = scale - 1; x < bm.Width; x += scale)
                    for (int y = 0; y < bm.Height; y++)
                        bm.SetPixel(x, y, gridColor);
                for (int y = scale - 1; y < bm.Height; y += scale)
                    for (int x = 0; x < bm.Width; x++)
                        bm.SetPixel(x, y, gridColor);
            }

            return bm;
        }

        /// <summary>
        /// Redraws the canvas from scratch
        /// </summary>
        private void FullRedraw()
        {
            canvas = RenderBitmap(zoom, showGrid.Checked);
            Redraw();
        }

        /// <summary>
        /// Redraws the canvas
        /// </summary>
        private void Redraw()
        {
            canvasBox.Image = canvas;
            canvasBox.Refresh();
            canvasBox.Update();

            // rip performance
            GC.Collect();
        }

        private void RedrawUITrigger(object sender, EventArgs e)
        {
            FullRedraw();
        }

        #endregion

        #region Zoom controls

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomLabel.Text = String.Format("Zoom: {0}%", zoom * 100);
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            zoom++;
            FullRedraw();
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 1) zoom--;
            FullRedraw();
        }

        private void ZoomReset_Click(object sender, EventArgs e)
        {
            zoom = Int32.Parse((sender as ToolStripItem).Tag as string);
            FullRedraw();
        }

        #endregion

        #region File saving/loading

        public const string FileHeader = "TGRV";

        private void OpenImage_Click(object sender, EventArgs e)
        {
            // get the filename
            var result = openVGA.ShowDialog(this);
            if (result != DialogResult.OK) return;

            // open the image
            Stream file = new FileStream(openVGA.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(file, Encoding.ASCII);

            // first check the header
            char[] header = br.ReadChars(FileHeader.Length);
            if (new string(header) != FileHeader) throw new Exception("Invalid format");

            // read the width and height
            var bmWidth = br.ReadUInt16();
            var bmHeight = br.ReadUInt16();

            // load in the rest of the data
            var bmData = br.ReadBytes(bmWidth * bmHeight);

            // create bitmap object
            bitmap = new CharBitmap(bmData, bmWidth);

            // done
            br.Close();

            // clear the history stacks
            undoStack.Clear();
            redoStack.Clear();

            // redraw the bitmap
            FullRedraw();

            // save filename
            this.OpenFileName = openVGA.FileName;
            this.OpenFileDirty = false;
            this.OpenFileImported = false;
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            // get the filename (if we don't have one)
            if (MustSaveAs) { 
                var result = saveVGA.ShowDialog(this);
                if (result == DialogResult.Cancel && e is FormClosingEventArgs)
                {
                    (e as FormClosingEventArgs).Cancel = true;
                }
                if (result != DialogResult.OK) return;
            } else
            {
                saveVGA.FileName = OpenFileName;
            }

            // save the image
            Stream file = new FileStream(saveVGA.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(file, Encoding.ASCII);
            bw.Write(FileHeader.ToCharArray()); // write a header
            bw.Write((ushort)bitmap.Width);
            bw.Write((ushort)bitmap.Height);
            bw.Write(bitmap.Data);
            bw.Close();

            // save filename
            this.OpenFileName = saveVGA.FileName;
            this.OpenFileDirty = false;
            this.OpenFileImported = false;
        }

        private void ExportImage_Click(object sender, EventArgs e)
        {
            // get the filename
            var result = saveExport.ShowDialog(this);
            if (result != DialogResult.OK) return;

            Bitmap bm = RenderBitmap(1, false);
            bm.Save(saveExport.FileName);
        }

        #endregion

        #region Mouse events

        private void DoMouse(int mouseX, int mouseY)
        {
            // 
            if (importer.IsBusy) return;

            // pick out the color
            byte color = 0;
            if (colorSelector.SelectedItems.Count > 0)
                color = Byte.Parse(colorSelector.SelectedItems[0].Text);

            // get real mouse coords
            mouseX /= zoom;
            mouseY /= zoom;

            // don't do anything out of scope
            if (mouseX >= bitmap.Width || mouseY >= bitmap.Height) return;

            // precalc offset and boundary check
            int offset = mouseY * bitmap.Width + mouseX;
            if (offset < 0 || offset >= bitmap.Data.Length) return;

            // pixel changes to commit to history
            var changes = new HashSet<PixelChange>();

            switch (drawMode)
            {
                case DrawMode.Draw:
                    PixelChange? change = DrawPixel(mouseX, mouseY, color);
                    if (change != null) changes.Add(change.Value);
                    redoStack.Clear();
                    break;
                case DrawMode.Fill:
                    var changeSet = FloodFill(mouseX, mouseY, color);
                    if (changeSet != null) changes.UnionWith(changeSet);
                    redoStack.Clear();
                    break;
                case DrawMode.Picker:
                    colorSelector.Items[bitmap.Data[offset]].Selected = true;
                    break;
                default:
                    throw new NotImplementedException("Draw mode " + drawMode.ToString() + " not implemented.");
            }

            // undo/redo stack things
            if (changes.Count > 0) { 
                undoStack.Push(new HistoryEvent(changes));
                OpenFileDirty = true;
            }
            UpdateStackButtons();

            // trigger canvasBox redraw
            Redraw();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newDialog = new Dialogs.NewArtwork();
            var result = newDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            var bmWidth = (int)newDialog.bmWidth.Value;
            var bmHeight = (int)newDialog.bmHeight.Value;

            bitmap = new CharBitmap(bmWidth, bmHeight);

            FullRedraw();

            OpenFileName = null;
            OpenFileDirty = false;
            OpenFileImported = false;
        }

        private void CanvasBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDraw = true;
            DoMouse(e.X, e.Y);
        }

        private void CanvasBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDraw = false;
            DoMouse(e.X, e.Y);
        }

        private void CanvasBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!importer.IsBusy)
                toolStripStatusLabel1.Text = String.Format("{0}, {1}", e.X / zoom, e.Y / zoom);

            if (!mouseDraw) return;
            DoMouse(e.X, e.Y);
        }

        private void CanvasBox_MouseLeave(object sender, EventArgs e)
        {
            mouseDraw = false;
        }

        #endregion

        private PixelChange? DrawPixel(int x, int y, byte color)
        {
            // precalc offset and check boundary
            int offset = y * bitmap.Width + x;
            if (offset < 0 || offset >= bitmap.Data.Length) return null;

            // don't do anything if the pixel is the same
            if (bitmap.Data[offset] == color) return null;

            // change the pixel and note the change
            var change = new PixelChange(offset, bitmap.Data[offset], color);
            bitmap.Data[offset] = color;

            // update the bitmap
            var gfx = Graphics.FromImage(canvas);
            gfx.FillRectangle(new SolidBrush(palette[color]),
                              x * zoom, y * zoom,
                              zoom - (showGrid.Checked ? 1 : 0),
                              zoom - (showGrid.Checked ? 1 : 0));

            return change;
        }

        private ISet<PixelChange> FloodFill(int x, int y, byte color)
        {
            // precalc offset and check boundary
            int offset = y * bitmap.Width + x;
            if (offset < 0 || offset >= bitmap.Data.Length) return null;

            var changes = new HashSet<PixelChange>();
            var visitedPixels = new HashSet<int>();

            var toVisit = new Queue<int>();
            toVisit.Enqueue(y * bitmap.Width + x);

            var gfx = Graphics.FromImage(canvas);

            while (toVisit.Count > 0)
            {
                var pixelOffset = toVisit.Dequeue();
                var pixelColor = bitmap.Data[pixelOffset];
                if (visitedPixels.Contains(pixelOffset)) continue;

                changes.Add(new PixelChange(pixelOffset, pixelColor, color));
                bitmap.Data[pixelOffset] = color;
                gfx.FillRectangle(new SolidBrush(palette[color]),
                                  (pixelOffset % bitmap.Width) * zoom, 
                                  (pixelOffset / bitmap.Width) * zoom,
                                  zoom - (showGrid.Checked ? 1 : 0),
                                  zoom - (showGrid.Checked ? 1 : 0));

                visitedPixels.Add(pixelOffset);

                int[] diff = new int[] { -bitmap.Width, bitmap.Width, -1, 1 };
                foreach (int offsetDiff in diff)
                {
                    var nextOffset = pixelOffset + offsetDiff;
                    try
                    {
                        if (pixelColor != bitmap.Data[nextOffset]) continue;
                        if (visitedPixels.Contains(nextOffset)) continue;

                        toVisit.Enqueue(nextOffset);
                    }
                    catch
                    {
                        ;
                    }
                }
            }

            return changes;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => new Dialogs.AboutBox().ShowDialog();

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStackButtons()
        {
            undoAction.Enabled = undoStack.Count > 0;
            redoAction.Enabled = redoStack.Count > 0;
        }

        private void UndoAction_Click(object sender, EventArgs e)
        {
            if (undoStack.Count <= 0) return;
            var action = undoStack.Pop();

            // undo it
            foreach (var change in action.Changes)
            {
                int x = change.Offset % bitmap.Width;
                int y = change.Offset / bitmap.Width;
                DrawPixel(x, y, change.OldColor);
            }

            // put it on the redo stack
            redoStack.Push(action);

            Redraw();
            UpdateStackButtons();
        }

        private void RedoAction_Click(object sender, EventArgs e)
        {
            if (redoStack.Count <= 0) return;
            var action = redoStack.Pop();

            // undo it
            foreach (var change in action.Changes)
            {
                int x = change.Offset % bitmap.Width;
                int y = change.Offset / bitmap.Width;
                DrawPixel(x, y, change.NewColor);
            }

            // put it on the redo stack
            undoStack.Push(action);

            Redraw();
            UpdateStackButtons();
        }

        #region Million color to 256 color importer

        // The importer is a BackgroundWorker which runs on a different thread.
        // Start => DoWork => ReportProgress v WorkerCompleted
        //            ^--------------------<===>-^

        private void Importer_DoWork(object sender, DoWorkEventArgs e)
        {
            // TODO: Make a more efficient importer.
            //       An idea I could try is ignore the CGA 16 color pallete and
            //       use the HSL values and round them to thes we have in the pallete.

            // open the image
            var bm = new Bitmap(openImport.FileName);
            var bmWidth = bm.Width;
            var bmHeight = bm.Height;
            var bmData = new byte[bmWidth * bmHeight];

            // go through each pixel and find the closest candidate
            int update = 0;
            for (int y = 0; y < bmHeight; y++)
                for (int x = 0; x < bmWidth; x++)
                {
                    Color thisColor = bm.GetPixel(x, y);
                    if (update++ == 10)
                    {
                        importer.ReportProgress(100 * (y * bmWidth + x) / bmData.Length,
                                                new ImporterStatus(y * bmWidth + x, bmData.Length));
                        update = 0;
                    }

                    if (thisColor.A == 0) {
                        bmData[y * bmWidth + x] = 0x00;
                        continue;
                    }

                    int minIndex = -1, min = int.MaxValue;
                    int[] overallDiff = new int[Palette.Length];
                    for (int i = 0; i < overallDiff.Length; i++)
                    {
                        Color vgaColor = palette[i];
                        overallDiff[i] += Math.Abs(thisColor.R - vgaColor.R);
                        overallDiff[i] += Math.Abs(thisColor.G - vgaColor.G);
                        overallDiff[i] += Math.Abs(thisColor.B - vgaColor.B);

                        if (overallDiff[i] < min)
                        {
                            min = overallDiff[i];
                            minIndex = i;
                        }
                    }

                    // set this pixel to the color
                    bmData[y * bmWidth + x] = (byte)minIndex;
                }

            // render a bitmap to apply when the worker finishes
            importer.ReportProgress(100, new ImporterStatus(true, bmData.Length));

            // save the bitmap data
            this.bitmap = new CharBitmap(bmData, bmWidth);
            this.canvas = RenderBitmap(this.zoom, this.showGrid.Checked);

            e.Result = true;
        }

        private void Importer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // update UI on importer progress
            importProgress.Value = e.ProgressPercentage;
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void Importer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // hide the import progress bar
            importProgress.Visible = false;
            toolStripStatusLabel1.Text = "";

            // release the user interface
            newToolStripMenuItem.Enabled = true;
            openImage.Enabled = true;
            saveImage.Enabled = true;
            exportImage.Enabled = true;
            importImage.Enabled = true;
            showPalette.Enabled = true;
            zoom100.Enabled = true;
            zoom200.Enabled = true;
            zoom500.Enabled = true;
            zoomIn.Enabled = true;
            zoomOut.Enabled = true;
            showGrid.Enabled = true;

            // redraw the UI
            Redraw();
        }

        #endregion

        #region Misc. UI Stuff

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thegreatrazz/VGAPainter/wiki");
        }

        private void ReportAnissueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thegreatrazz/VGAPainter/issues");
        }

        private void DrawTool_Select(object sender, EventArgs e)
        {
            foreach (var el in menuEdit.DropDownItems)
            {
                if (!(el is ToolStripMenuItem)) continue;
                (el as ToolStripMenuItem).Checked = false;
            }

            if (!(sender is ToolStripMenuItem)) return;
            ToolStripMenuItem toolSelector = (ToolStripMenuItem)sender;
            drawMode = (DrawMode)Enum.Parse(drawMode.GetType(), toolSelector.Tag as string);
            toolSelector.Checked = true;
            statusMode.Text = drawMode.ToString();
        }

        private void ColorSelector_DoubleClick(object sender, EventArgs e)
        {
            byte color = 0;
            if (colorSelector.SelectedItems.Count > 0)
                color = Byte.Parse(colorSelector.SelectedItems[0].Text);

            colorDialog1.Color = palette[color];
            var result = colorDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            palette[color] = colorDialog1.Color;
            ColorSelector_Update();
        }

        private void GrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palette = Palette.Grayscale;
            ColorSelector_Update();
        }

        private void VGAMode13hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palette = Palette.VGA;
            ColorSelector_Update();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: rewrite this function
            var importDialog = new OpenFileDialog();
            importDialog.Filter = "VGAPainter Artwork Palette|*.vap";
            importDialog.DefaultExt = "vap";
            importDialog.Title = "Import artwork palette";
            var dialogResult = importDialog.ShowDialog(this);

            // stop on user cancel
            if (dialogResult != DialogResult.OK) return;

            // import the palette
            palette = Palette.Load(importDialog.FileName);
            ColorSelector_Update();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportDialog = new SaveFileDialog();
            exportDialog.Filter = "VGAPainter Artwork Palette|*.vap";
            exportDialog.DefaultExt = "vap";
            exportDialog.Title = "Import artwork palette";
            var dialogResult = exportDialog.ShowDialog(this);

            // stop on user cancel
            if (dialogResult != DialogResult.OK) return;

            // export the palette
            palette.Save(exportDialog.FileName);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // prevent the program from closing if the image is being edited

            if (undoStack.Count > 0 || OpenFileDirty || OpenFileImported)
            {
                var result = MessageBox.Show("Would you like to save your work before quitting?", "Save and Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel) e.Cancel = true;
                if (result == DialogResult.Yes)
                {
                    SaveImage_Click(sender, e);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // shim
            MustSaveAs = true;
            SaveImage_Click(sender, e);
        }

        private void windowTitle()
        {
            // cobbles together then sets the window title
            string suffix = " - VGAPainter";
            string filename = "Untitled";
            string dirty = OpenFileDirty ? "*" : "";
            string imported = OpenFileImported ? " (imported)" : "";
            if (this.OpenFileName != null)
            {
                filename = Path.GetFileName(this.OpenFileName);
            }

            string title = dirty + filename + imported + suffix;
            this.Text = title;
        }

        #endregion

        private void vGAOptimisedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open file to import
            var result = openImport.ShowDialog();
            if (result != DialogResult.OK) return;

            // test-load the image to check for format
            Bitmap bitmap;
            try
            {
                bitmap = new Bitmap(openImport.FileName);
            }
            catch (ArgumentException ex)
            {
                // what the blin?
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var imported = ImporterOptimised.Import(bitmap);

            // stop here if import failed / cancelled
            if (imported == null)
            {
                return;
            }

            // set palette to VGA
            palette = Palette.VGA;

            // clear the stack
            undoStack.Clear();
            redoStack.Clear();
            UpdateStackButtons();

            // save image info
            this.OpenFileName = openImport.FileName;
            this.OpenFileDirty = false;
            this.OpenFileImported = true;

            // redraw
            this.bitmap = imported;
            FullRedraw();
        }

        private void defaultImporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open file to import
            var result = openImport.ShowDialog();
            if (result != DialogResult.OK) return;

            // test-load the image to check for format
            Bitmap bitmap;
            try
            {
                bitmap = new Bitmap(openImport.FileName);
            }
            catch (ArgumentException ex)
            {
                // what the blin?
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ImporterGenericArgs args = new ImporterGenericArgs()
            {
                DitherLevel = 0,
                Palette = this.palette
            };
            var imported = ImporterGeneric.Import(bitmap, args);

            // stop here if import failed / cancelled
            if (imported == null)
            {
                return;
            }

            // clear the stack
            undoStack.Clear();
            redoStack.Clear();
            UpdateStackButtons();

            // save image info
            this.OpenFileName = openImport.FileName;
            this.OpenFileDirty = false;
            this.OpenFileImported = true;

            // redraw
            this.bitmap = imported;
            FullRedraw();
        }
    }

    /// <summary>
    /// Class for storing the status of the importer
    /// </summary>
    class ImporterStatus
    {
        public int Progress { get; private set; }
        public int Total { get; private set; }
        public bool BitmapRender { get; private set; }

        public ImporterStatus(bool bitmap, int total)
        {
            BitmapRender = bitmap;
            Total = total;
            Progress = total;
        }

        public ImporterStatus(int progress, int total)
        {
            BitmapRender = false;
            Progress = progress;
            Total = total;
        }

        public override string ToString()
        {
            if (BitmapRender) return "Rendering bitmap...";
            return String.Format("{0} / {1} pixels processed", Progress, Total);
        }
    }
}
