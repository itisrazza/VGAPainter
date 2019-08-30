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

namespace VGAPainter
{
    public enum DrawMode
    {
        Pixel,
        Fill,
        Picker
    }

    public partial class MainForm : Form
    {
        private Color[] vgaPalette;
        private int bmWidth = 16, bmHeight = 16;
        private byte[] bmData = new byte[256];
        private int zoom = 5;
        private bool mouseDraw = false;
        private DrawMode drawMode;

        public MainForm()
        {
            GeneratePalette();
            InitializeComponent();

            // populate list with colours
            ImageList imgList = new ImageList();
            colorSelector.LargeImageList = imgList;
            colorSelector.SmallImageList = imgList;
            for (int i = 0; i < vgaPalette.Length; i++)
            {
                Color color = vgaPalette[i];
                Bitmap bm = new Bitmap(16, 16);
                for (int y = 0; y < 16; y++)
                    for (int x = 0; x < 16; x++)
                        bm.SetPixel(x, y, color);

                ListViewItem listItem = new ListViewItem(i.ToString(), i);
                listItem.SubItems.Add(String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B));

                colorSelector.Items.Add(listItem);
                imgList.Images.Add(bm);
            }

            // draw the empty image
            Redraw();
        }

        #region VGA Palette Generation

        /// <summary>
        /// Converts an HSL color into a .NET Color object
        /// </summary>
        private Color FromHsv(double h, double s, double v)
        {
            h %= 360;    // limit to 360 degrees

            var c = v * s;
            var x = c * (1 - Math.Abs((h / 60) % 2 - 1));
            var m = v - c;

            double r, g, b;

            if (h >= 0 && h < 60)
            {
                r = c;
                g = x;
                b = 0;
            }
            else if (h >= 60 && h < 120)
            {
                r = x;
                g = c;
                b = 0;
            }
            else if (h >= 120 && h < 180)
            {
                r = 0;
                g = c;
                b = x;
            }
            else if (h >= 180 && h < 240)
            {
                r = 0;
                g = x;
                b = c;
            }
            else if (h >= 240 && h < 300)
            {
                r = x;
                g = 0;
                b = c;
            }
            else if (h >= 300 && h < 360)
            {
                r = c;
                g = 0;
                b = x;
            }
            else throw new Exception("Value not inside range 0..360");

            // add m to r, g, b
            r = Clip(r + m);
            g = Clip(g + m);
            b = Clip(b + m);

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)((b * 255)));
        }

        /// <summary>
        /// Clips the value within a range
        /// </summary>
        double Clip(double input, double min = 0, double max = 1) => input < min ? min : input > max ? max : input;

        private void GeneratePalette()
        {
            vgaPalette = new Color[256];
            int index = 0;  // an index into the array

            // CGA color palette
            vgaPalette[index++] = Color.FromArgb(0, 0, 0);          // 0 - black
            vgaPalette[index++] = Color.FromArgb(0, 0, 170);        // 1 - blue
            vgaPalette[index++] = Color.FromArgb(0, 170, 0);        // 2 - green 
            vgaPalette[index++] = Color.FromArgb(0, 170, 170);      // 3 - cyan
            vgaPalette[index++] = Color.FromArgb(170, 0, 0);        // 4 - red 
            vgaPalette[index++] = Color.FromArgb(170, 0, 170);      // 5 - magenta
            vgaPalette[index++] = Color.FromArgb(170, 85, 170);     // 6 - brown
            vgaPalette[index++] = Color.FromArgb(170, 170, 170);    // 7 - gray
            vgaPalette[index++] = Color.FromArgb(85, 85, 85);       // 8 - lighter black
            vgaPalette[index++] = Color.FromArgb(85, 85, 255);      // 9 - lighter blue
            vgaPalette[index++] = Color.FromArgb(85, 255, 85);      // A - lighter green 
            vgaPalette[index++] = Color.FromArgb(85, 255, 255);     // B - lighter cyan
            vgaPalette[index++] = Color.FromArgb(255, 85, 85);      // C - lighter red 
            vgaPalette[index++] = Color.FromArgb(255, 85, 255);     // D - lighter magenta
            vgaPalette[index++] = Color.FromArgb(255, 255, 85);     // E - lighter brown
            vgaPalette[index++] = Color.FromArgb(255, 255, 255);    // F - lighter gray

            // greyscale
            {
                byte grey = 0x00;
                for (int i = 0; i < 16; i++)
                {
                    vgaPalette[index++] = Color.FromArgb(grey, grey, grey);
                    grey += 0x10;
                }
            }

            // value array
            double[] satLum = { 1.0, 0.5, 0.25 };

            // general rainbow for various luminances
            foreach (double lum in satLum)
                foreach (double sat in satLum)
                    for (int i = 240; i < 240 + 360; i += 15)
                    {
                        vgaPalette[index++] = FromHsv(i, sat, lum);
                    }

            // hsl(X, 1.0, 1.0) where X = 240..(240 + 360)
            // hsl(X, 0.5, 1.0)
            // hsl(X, 0.25, 1.0)
            // hsl(X, 1.0, 0.5)
            // hsl(X, 0.5, 0.5)
            // hsl(X, 0.25, 0.5)
            // hsl(X, 1.0, 0.25)
            // hsl(X, 0.5, 0.25)
            // hsl(X, 0.25, 0.25)

            // fill the rest of the palette with black
            while (index < vgaPalette.Length)
                vgaPalette[index++] = Color.FromArgb(0, 0, 0);
        }

        private void ShowPalette_Click(object sender, EventArgs e)
        {
            bmWidth = 16;
            bmHeight = vgaPalette.Length / bmWidth;
            bmData = new byte[bmWidth * bmHeight];

            for (int i = 0; i <= byte.MaxValue; i++)
            {
                bmData[i] = (byte)i;
            }

            Redraw();
        }

        #endregion

        #region Bitmap rendering
        
        /// <summary>
        /// Renders the bitmap for modern screens
        /// </summary>
        private Bitmap RenderBitmap(int scale, bool grid)
        {
            if (scale <= 0) return null;

            // create .NET bitmap
            Bitmap bm = new Bitmap(bmWidth * scale, bmHeight * scale);
            Graphics gfx = Graphics.FromImage(bm);

            // copy the pixels
            for (int y = 0; y < bmHeight; y++)
                for (int x = 0; x < bmWidth; x++)
                {
                    Color pixel = vgaPalette[bmData[y * bmWidth + x]];
                    gfx.FillRectangle(new SolidBrush(pixel), x * scale, y * scale, scale, scale);
                }

            // draw a grid
            if (grid && scale > 1)
            {
                Pen gridPen = Pens.Gray;
                for (int x = scale - 1; x < bm.Width; x += scale)
                    gfx.DrawLine(gridPen, x, 0, x, bm.Height);
                for (int y = scale - 1; y < bm.Height; y += scale)
                    gfx.DrawLine(gridPen, 0, y, bm.Width, y);
            }

            return bm;
        }

        /// <summary>
        /// Redraws the canvas
        /// </summary>
        private void Redraw()
        {
            canvasBox.Image = RenderBitmap(zoom, showGrid.Checked);
        }

        private void RedrawUITrigger(object sender, EventArgs e)
        {
            Redraw();
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
            Redraw();
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 1) zoom--;
            Redraw();
        }

        private void ZoomReset_Click(object sender, EventArgs e)
        {
            zoom = Int32.Parse((sender as ToolStripItem).Tag as string);
            Redraw();
        }

        #endregion

        #region File saving/loading

        public const string FileHeader = "TGRV";

        private void OpenImage_Click(object sender, EventArgs e)
        {
            // get the filename
            var result = openTgr.ShowDialog(this);
            if (result != DialogResult.OK) return;

            // open the image
            Stream file = new FileStream(openTgr.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(file, Encoding.ASCII);

            // first check the header
            char[] header = br.ReadChars(FileHeader.Length);
            if (new string(header) != FileHeader) throw new Exception("Invalid format");

            // read the width and height
            bmWidth = br.ReadUInt16();
            bmHeight = br.ReadUInt16();

            // load in the rest of the data
            bmData = br.ReadBytes(bmWidth * bmHeight);

            // done
            br.Close();

            Redraw();
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            // get the filename
            var result = saveTgr.ShowDialog(this);
            if (result != DialogResult.OK) return;

            // save the image
            Stream file = new FileStream(saveTgr.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(file, Encoding.ASCII);
            bw.Write(FileHeader.ToCharArray()); // write a header
            bw.Write((ushort)bmWidth);
            bw.Write((ushort)bmHeight);
            bw.Write(bmData);
            bw.Close();
        }

        private void ImportImage_Click(object sender, EventArgs e)
        {

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
            // pick out the color
            byte color = 0;
            if (colorSelector.SelectedItems.Count > 0)
                color = Byte.Parse(colorSelector.SelectedItems[0].Text);

            // get real mouse coords
            mouseX /= zoom;
            mouseY /= zoom;

            // don't do anything out of scope
            if (mouseX >= bmWidth || mouseY >= bmHeight) return;

            // pre-calc image offset
            int offset = mouseY * bmWidth + mouseX;
            if (offset < 0 || offset >= bmData.Length) return;

            switch (drawMode)
            {
                case DrawMode.Pixel:
                    bmData[offset] = color;
                    break;
                case DrawMode.Picker:
                    colorSelector.Items[bmData[offset]].Selected = true;
                    break;
                default:
                    throw new NotImplementedException("Draw mode " + drawMode.ToString() + " not implemented.");
            }

            Redraw();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewArtwork newDialog = new NewArtwork();
            var result = newDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            bmWidth = (int)newDialog.bmWidth.Value;
            bmHeight = (int)newDialog.bmHeight.Value;
            bmData = new byte[bmWidth * bmHeight];

            Redraw();
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
            if (!mouseDraw) return;
            DoMouse(e.X, e.Y);
        }

        private void CanvasBox_MouseLeave(object sender, EventArgs e)
        {
            mouseDraw = false;
        }

        #endregion

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VGAPainter by thegreatrazz\n" +
                "https://github.com/thegreatrazz/VGAPainter");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            drawMode = (DrawMode)toolSelector.Tag;
            toolSelector.Checked = true;
        }

    }
}
