namespace VGAPainter.Dialogs
{
    partial class ImportDialog
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
            this.optimisedImportCheck = new System.Windows.Forms.CheckBox();
            this.paletteLabel = new System.Windows.Forms.Label();
            this.paletteCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.ditheringCheck = new System.Windows.Forms.CheckBox();
            this.ditheringDepth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditheringDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // optimisedImportCheck
            // 
            this.optimisedImportCheck.AutoSize = true;
            this.optimisedImportCheck.Location = new System.Drawing.Point(12, 12);
            this.optimisedImportCheck.Name = "optimisedImportCheck";
            this.optimisedImportCheck.Size = new System.Drawing.Size(212, 19);
            this.optimisedImportCheck.TabIndex = 0;
            this.optimisedImportCheck.Text = "Use &Optimised Importer (VGA only)";
            this.optimisedImportCheck.UseVisualStyleBackColor = true;
            this.optimisedImportCheck.CheckedChanged += new System.EventHandler(this.optimisedImportCheck_CheckedChanged);
            // 
            // paletteLabel
            // 
            this.paletteLabel.AutoSize = true;
            this.paletteLabel.Location = new System.Drawing.Point(12, 41);
            this.paletteLabel.Name = "paletteLabel";
            this.paletteLabel.Size = new System.Drawing.Size(46, 15);
            this.paletteLabel.TabIndex = 1;
            this.paletteLabel.Text = "&Palette:";
            // 
            // paletteCombo
            // 
            this.paletteCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteCombo.FormattingEnabled = true;
            this.paletteCombo.Location = new System.Drawing.Point(64, 38);
            this.paletteCombo.Name = "paletteCombo";
            this.paletteCombo.Size = new System.Drawing.Size(294, 23);
            this.paletteCombo.TabIndex = 2;
            this.paletteCombo.SelectedIndexChanged += new System.EventHandler(this.paletteCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ditheringDepth);
            this.groupBox1.Controls.Add(this.ditheringCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 363);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unoptimised Importer Options";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(283, 436);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(202, 436);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&Import";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ditheringCheck
            // 
            this.ditheringCheck.AutoSize = true;
            this.ditheringCheck.Location = new System.Drawing.Point(6, 23);
            this.ditheringCheck.Name = "ditheringCheck";
            this.ditheringCheck.Size = new System.Drawing.Size(78, 19);
            this.ditheringCheck.TabIndex = 7;
            this.ditheringCheck.Text = "&Dithering:";
            this.ditheringCheck.UseVisualStyleBackColor = true;
            // 
            // ditheringDepth
            // 
            this.ditheringDepth.Location = new System.Drawing.Point(90, 22);
            this.ditheringDepth.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.ditheringDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ditheringDepth.Name = "ditheringDepth";
            this.ditheringDepth.Size = new System.Drawing.Size(250, 23);
            this.ditheringDepth.TabIndex = 8;
            this.ditheringDepth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ImportDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(370, 471);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paletteCombo);
            this.Controls.Add(this.paletteLabel);
            this.Controls.Add(this.optimisedImportCheck);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ditheringDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox optimisedImportCheck;
        private System.Windows.Forms.Label paletteLabel;
        private System.Windows.Forms.ComboBox paletteCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown ditheringDepth;
        private System.Windows.Forms.CheckBox ditheringCheck;
    }
}