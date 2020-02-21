using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGAPainter.Dialogs
{
    public partial class ProgressBox : Form
    {
        public string ProgressText
        {
            get
            {
                return progressText.Text;
            }

            set
            {
                progressText.Text = value;
            }
        }   

        public int Value { get => progressBar.Value; set => progressBar.Value = value; }

        public int Minimum { get => progressBar.Minimum; set => progressBar.Minimum = value; }
        public int Maximum { get => progressBar.Maximum; set => progressBar.Maximum = value; }
        
        public ProgressBox()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
