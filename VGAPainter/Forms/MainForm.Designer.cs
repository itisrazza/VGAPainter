namespace VGAPainter.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importImage = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vGAOptimisedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAction = new System.Windows.Forms.ToolStripMenuItem();
            this.redoAction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.builtinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vGAMode13hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnissueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVGA = new System.Windows.Forms.SaveFileDialog();
            this.saveExport = new System.Windows.Forms.SaveFileDialog();
            this.colorSelector = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.openVGA = new System.Windows.Forms.OpenFileDialog();
            this.openImport = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.importProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.paletteToolStripMenuItem,
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
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importImage,
            this.exportImage,
            this.toolStripSeparator2,
            this.exit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "&New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(192, 6);
            // 
            // openImage
            // 
            this.openImage.Name = "openImage";
            this.openImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImage.Size = new System.Drawing.Size(195, 22);
            this.openImage.Text = "&Open...";
            this.openImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImage.Size = new System.Drawing.Size(195, 22);
            this.saveImage.Text = "&Save";
            this.saveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // importImage
            // 
            this.importImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultImporterToolStripMenuItem,
            this.vGAOptimisedToolStripMenuItem});
            this.importImage.Name = "importImage";
            this.importImage.Size = new System.Drawing.Size(195, 22);
            this.importImage.Text = "&Import";
            // 
            // defaultImporterToolStripMenuItem
            // 
            this.defaultImporterToolStripMenuItem.Name = "defaultImporterToolStripMenuItem";
            this.defaultImporterToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.defaultImporterToolStripMenuItem.Text = "&Generic Import (Slower)";
            this.defaultImporterToolStripMenuItem.Click += new System.EventHandler(this.defaultImporterToolStripMenuItem_Click);
            // 
            // vGAOptimisedToolStripMenuItem
            // 
            this.vGAOptimisedToolStripMenuItem.Name = "vGAOptimisedToolStripMenuItem";
            this.vGAOptimisedToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.vGAOptimisedToolStripMenuItem.Text = "&VGA Import (Faster, VGA Palette)";
            this.vGAOptimisedToolStripMenuItem.Click += new System.EventHandler(this.vGAOptimisedToolStripMenuItem_Click);
            // 
            // exportImage
            // 
            this.exportImage.Name = "exportImage";
            this.exportImage.Size = new System.Drawing.Size(195, 22);
            this.exportImage.Text = "&Export...";
            this.exportImage.Click += new System.EventHandler(this.ExportImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(195, 22);
            this.exit.Text = "E&xit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoAction,
            this.redoAction,
            this.toolStripSeparator8,
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
            // undoAction
            // 
            this.undoAction.Name = "undoAction";
            this.undoAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoAction.Size = new System.Drawing.Size(148, 22);
            this.undoAction.Text = "&Undo";
            this.undoAction.Click += new System.EventHandler(this.UndoAction_Click);
            // 
            // redoAction
            // 
            this.redoAction.Name = "redoAction";
            this.redoAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoAction.Size = new System.Drawing.Size(148, 22);
            this.redoAction.Text = "&Redo";
            this.redoAction.Click += new System.EventHandler(this.RedoAction_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(145, 6);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Checked = true;
            this.drawToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.drawToolStripMenuItem.Tag = "Draw";
            this.drawToolStripMenuItem.Text = "&Draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fillToolStripMenuItem.Tag = "Fill";
            this.fillToolStripMenuItem.Text = "&Fill";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
            // 
            // pixerToolStripMenuItem
            // 
            this.pixerToolStripMenuItem.Name = "pixerToolStripMenuItem";
            this.pixerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.pixerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pixerToolStripMenuItem.Tag = "Picker";
            this.pixerToolStripMenuItem.Text = "&Picker";
            this.pixerToolStripMenuItem.Click += new System.EventHandler(this.DrawTool_Select);
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
            this.loadPaletteToolStripMenuItem.Enabled = false;
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
            // paletteToolStripMenuItem
            // 
            this.paletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.toolStripSeparator11,
            this.builtinToolStripMenuItem,
            this.toolStripSeparator10,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
            this.paletteToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.paletteToolStripMenuItem.Text = "&Palette";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.changeColorToolStripMenuItem.Text = "&Change color...";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(151, 6);
            // 
            // builtinToolStripMenuItem
            // 
            this.builtinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.vGAMode13hToolStripMenuItem});
            this.builtinToolStripMenuItem.Name = "builtinToolStripMenuItem";
            this.builtinToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.builtinToolStripMenuItem.Text = "&Built-in";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.GrayscaleToolStripMenuItem_Click);
            // 
            // vGAMode13hToolStripMenuItem
            // 
            this.vGAMode13hToolStripMenuItem.Name = "vGAMode13hToolStripMenuItem";
            this.vGAMode13hToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.vGAMode13hToolStripMenuItem.Text = "VGA (Mode 13h)";
            this.vGAMode13hToolStripMenuItem.Click += new System.EventHandler(this.VGAMode13hToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(151, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.importToolStripMenuItem.Text = "&Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exportToolStripMenuItem.Text = "&Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.reportAnissueToolStripMenuItem,
            this.toolStripSeparator9,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1_Click);
            // 
            // reportAnissueToolStripMenuItem
            // 
            this.reportAnissueToolStripMenuItem.Name = "reportAnissueToolStripMenuItem";
            this.reportAnissueToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reportAnissueToolStripMenuItem.Text = "Report an &issue...";
            this.reportAnissueToolStripMenuItem.Click += new System.EventHandler(this.ReportAnissueToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // saveVGA
            // 
            this.saveVGA.DefaultExt = "vad";
            this.saveVGA.Filter = "VGA Artwork Data|*.vad";
            this.saveVGA.Title = "Save VGA artwork";
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
            this.colorSelector.DoubleClick += new System.EventHandler(this.ColorSelector_DoubleClick);
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
            this.canvasBox.Location = new System.Drawing.Point(0, 0);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(369, 265);
            this.canvasBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvasBox.TabIndex = 2;
            this.canvasBox.TabStop = false;
            this.canvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseDown);
            this.canvasBox.MouseLeave += new System.EventHandler(this.CanvasBox_MouseLeave);
            this.canvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseMove);
            this.canvasBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasBox_MouseUp);
            // 
            // openVGA
            // 
            this.openVGA.DefaultExt = "vad";
            this.openVGA.FileName = "*.vad";
            this.openVGA.Filter = "VGA Artwork Data|*.vad";
            // 
            // openImport
            // 
            this.openImport.Filter = "Any files|*.*|PNG (Portable Network Graphics)|*.png|BMP (Bitmap)|*.bmp|GIF (Graph" +
    "ics Interchange Format)|*.gif";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.canvasBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(144, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 404);
            this.panel1.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMode,
            this.importProgress,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(144, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(656, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusMode
            // 
            this.statusMode.Name = "statusMode";
            this.statusMode.Size = new System.Drawing.Size(0, 17);
            // 
            // importProgress
            // 
            this.importProgress.Name = "importProgress";
            this.importProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.colorSelector);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "VGAPainter (initialising...)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem exit;
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
        private System.Windows.Forms.SaveFileDialog saveVGA;
        private System.Windows.Forms.SaveFileDialog saveExport;
        private System.Windows.Forms.ListView colorSelector;
        private System.Windows.Forms.PictureBox canvasBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem pixerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openVGA;
        private System.Windows.Forms.OpenFileDialog openImport;
        private System.Windows.Forms.ToolStripMenuItem loadPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem showGrid;
        private System.Windows.Forms.ToolStripMenuItem undoAction;
        private System.Windows.Forms.ToolStripMenuItem redoAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar importProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusMode;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportAnissueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem builtinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vGAMode13hToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultImporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vGAOptimisedToolStripMenuItem;
    }
}

