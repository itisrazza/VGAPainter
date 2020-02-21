using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VGAPainter.Data;

namespace VGAPainter.Dialogs
{
    public partial class ImportDialog : Form
    {
        public Palette Palette { get; private set; }



        public ImportDialog()
        {
            InitializeComponent();
        }
    }
}
