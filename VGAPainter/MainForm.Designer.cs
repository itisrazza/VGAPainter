namespace VGAPainter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importImage = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getTheFuckOutXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.zoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom500 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.showGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTgr = new System.Windows.Forms.SaveFileDialog();
            this.saveExport = new System.Windows.Forms.SaveFileDialog();
            this.colorSelector = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.openTgr = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator6,
            this.openImage,
            this.saveImage,
            this.toolStripSeparator1,
            this.importImage,
            this.exportImage,
            this.toolStripSeparator2,
            this.getTheFuckOutXToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // openImage
            // 
            this.openImage.Name = "openImage";
            this.openImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImage.Size = new System.Drawing.Size(180, 22);
            this.openImage.Text = "&Open...";
            this.openImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImage.Size = new System.Drawing.Size(180, 22);
            this.saveImage.Text = "&Save...";
            this.saveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // importImage
            // 
            this.importImage.Name = "importImage";
            this.importImage.Size = new System.Drawing.Size(180, 22);
            this.importImage.Text = "&Import";
            // 
            // exportImage
            // 
            this.exportImage.Name = "exportImage";
            this.exportImage.Size = new System.Drawing.Size(180, 22);
            this.exportImage.Text = "&Export";
            this.exportImage.Click += new System.EventHandler(this.ExportImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // getTheFuckOutXToolStripMenuItem
            // 
            this.getTheFuckOutXToolStripMenuItem.Name = "getTheFuckOutXToolStripMenuItem";
            this.getTheFuckOutXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.getTheFuckOutXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getTheFuckOutXToolStripMenuItem.Text = "E&xit";
            this.getTheFuckOutXToolStripMenuItem.Click += new System.EventHandler(this.GetTheFuckOutXToolStripMenuItem_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.pixerToolStripMenuItem,
            this.toolStripSeparator3,
            this.showPalette,
            this.loadPaletteToolStripMenuItem});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // showPalette
            // 
            this.showPalette.Name = "showPalette";
            this.showPalette.Size = new System.Drawing.Size(148, 22);
            this.showPalette.Text = "&Show Palette";
            this.showPalette.Click += new System.EventHandler(this.ShowPalette_Click);
            // 
            // loadPaletteToolStripMenuItem
            // 
            this.loadPaletteToolStripMenuItem.Name = "loadPaletteToolStripMenuItem";
            this.loadPaletteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadPaletteToolStripMenuItem.Text = "&Load Palette...";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomLabel,
            this.toolStripSeparator5,
            this.zoomIn,
            this.zoomOut,
            this.toolStripSeparator4,
            this.zoom100,
            this.zoom200,
            this.zoom500,
            this.toolStripSeparator7,
            this.showGrid});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            this.menuView.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.Enabled = false;
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(220, 22);
            this.zoomLabel.Text = "Zoom: {0}%";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // zoomIn
            // 
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomIn.Size = new System.Drawing.Size(220, 22);
            this.zoomIn.Text = "Zoom in";
            this.zoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOut.Size = new System.Drawing.Size(220, 22);
            this.zoomOut.Text = "Zoom out";
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // zoom100
            // 
            this.zoom100.Name = "zoom100";
            this.zoom100.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zoom100.Size = new System.Drawing.Size(220, 22);
            this.zoom100.Tag = "1";
            this.zoom100.Text = "Zoom 100%";
            this.zoom100.Click += new System.EventHandler(this.ZoomReset_Click);
            // 
            // zoom200
            // 
            this.zoom200.Name = "zoom200";
            this.zoom200.Size = new System.Drawing.Size(220, 22);
            this.zoom200.Tag = "2";
            this.zoom200.Text = "Zoom 200%";
            this.zoom200.Click += new System.EventHandler(this.ZoomReset_Click);
            // 
            // zoom500
            // 
            this.zoom500.Name = "zoom500";
            this.zoom500.Size = new System.Drawing.Size(220, 22);
            this.zoom500.Tag = "5";
            this.zoom500.Text = "Zoom 500%";
            this.zoom500.Click += new System.EventHandler(this.ZoomReset_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(217, 6);
            // 
            // showGrid
            // 
            this.showGrid.Checked = true;
            this.showGrid.CheckOnClick = true;
            this.showGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGrid.Name = "showGrid";
            this.showGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.showGrid.Size = new System.Drawing.Size(220, 22);
            this.showGrid.Text = "Show &Grid";
            this.showGrid.CheckedChanged += new System.EventHandler(this.RedrawUITrigger);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // saveTgr
            // 
            this.saveTgr.DefaultExt = "vad";
            this.saveTgr.Filter = "VGA Artwork Data|*.vad";
            this.saveTgr.Title = "Save VGA artwork";
            // 
            // saveExport
            // 
            this.saveExport.DefaultExt = "png";
            this.saveExport.Filter = "PNG (Portable Network Graphics)|*.png|BMP (Bitmap)|*.bmp|GIF (Graphics Interchang" +
    "e Format)|*.gif";
            this.saveExport.Title = "Export VGA artwork";
            // 
            // colorSelector
            // 
            this.colorSelector.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.colorSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorSelector.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.colorSelector.HideSelection = false;
            this.colorSelector.Location = new System.Drawing.Point(0, 24);
            this.colorSelector.MultiSelect = false;
            this.colorSelector.Name = "colorSelector";
            this.colorSelector.Size = new System.Drawing.Size(144, 426);
            this.colorSelector.TabIndex = 1;
            this.colorSelector.UseCompatibleStateImageBehavior = false;
            this.colorSelector.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "VGA";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RGB";
            this.columnHeader2.Width = 90;
            // 
            // canvasBox
            // 
            this.canvasBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.canvasBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasBox.Location = new System.Drawing.Point(144, 24);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(656, 426);
            this.canvasBox.TabIndex = 2;
            this.canvasBox.TabStop = false;
            this.canvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseDown);
            this.canvasBox.MouseLeave += new System.EventHandler(this.CanvasBox_MouseLeave);
            this.canvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseMove);
            this.canvasBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseUp);
            // 
            // openTgr
            // 
            this.openTgr.DefaultExt = "vad";
            this.openTgr.FileName = "*.vad";
            this.openTgr.Filter = "VGA Artwork Data|*.vad";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Checked = true;
            this.drawToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.drawToolStripMenuItem.Tag = VGAPainter.DrawMode.Pixel;
            this.drawToolStripMenuItem.Text = "&Draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fillToolStripMenuItem.Tag = VGAPainter.DrawMode.Fill;
            this.fillToolStripMenuItem.Text = "&Fill";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
            // 
            // pixerToolStripMenuItem
            // 
            this.pixerToolStripMenuItem.Name = "pixerToolStripMenuItem";
            this.pixerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pixerToolStripMenuItem.Tag = VGAPainter.DrawMode.Picker;
            this.pixerToolStripMenuItem.Text = "&Picker";
            this.pixerToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvasBox);
            this.Controls.Add(this.colorSelector);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Raresh\'s VGA Painter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem openImage;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importImage;
        private System.Windows.Forms.ToolStripMenuItem exportImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem getTheFuckOutXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showPalette;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem zoomLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem zoomIn;
        private System.Windows.Forms.ToolStripMenuItem zoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem zoom100;
        private System.Windows.Forms.ToolStripMenuItem zoom200;
        private System.Windows.Forms.ToolStripMenuItem zoom500;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SaveFileDialog saveTgr;
        private System.Windows.Forms.SaveFileDialog saveExport;
        private System.Windows.Forms.ListView colorSelector;
        private System.Windows.Forms.PictureBox canvasBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem pixerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openTgr;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem loadPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem showGrid;
    }
}

