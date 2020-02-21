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
        public bool OptimisedVGA { get => optimisedImportCheck.Checked; }

        public Palette Palette { get; private set; }

        public int Dithering { get => (int)ditheringDepth.Value; }

        public ImportDialog()
        {
            InitializeComponent();

            // populate combo box with known palettes
            paletteCombo.Items.Clear();
            foreach (var palette in Palette.KnownPalettes.Keys)
            {
                paletteCombo.Items.Add(palette);
            }
            paletteCombo.Items.Add("Browse a palette...");

            // don't use optimised importer by default

        }

        private void optimisedImportCheck_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !optimisedImportCheck.Checked;
            if (optimisedImportCheck.Checked)
            {
                paletteCombo.SelectedValue = "VGA";
            }
        }

        private void paletteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // foreign palete
            if (paletteCombo.SelectedIndex == paletteCombo.Items.Count - 1)
            {
                // browse and import palette
                MessageBox.Show("Foreign palette selection not yet implemented.");
                return;
            }

            // known palette
            Palette = Palette.KnownPalettes[(string)paletteCombo.SelectedValue];
        }
    }
}
