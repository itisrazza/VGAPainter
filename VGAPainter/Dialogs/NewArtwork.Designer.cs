namespace VGAPainter.Dialogs
{
    partial class NewArtwork
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
            this.bmWidth = new System.Windows.Forms.NumericUpDown();
            this.bmHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bmWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // bmWidth
            // 
            this.bmWidth.Location = new System.Drawing.Point(56, 12);
            this.bmWidth.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.bmWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bmWidth.Name = "bmWidth";
            this.bmWidth.Size = new System.Drawing.Size(121, 20);
            this.bmWidth.TabIndex = 0;
            this.bmWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // bmHeight
            // 
            this.bmHeight.Location = new System.Drawing.Point(56, 38);
            this.bmHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.bmHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bmHeight.Name = "bmHeight";
            this.bmHeight.Size = new System.Drawing.Size(121, 20);
            this.bmHeight.TabIndex = 1;
            this.bmHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Height:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(21, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(189, 105);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmHeight);
            this.Controls.Add(this.bmWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New artwork";
            ((System.ComponentModel.ISupportInitialize)(this.bmWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown bmWidth;
        public System.Windows.Forms.NumericUpDown bmHeight;
    }
}