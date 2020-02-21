using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VGAPainter.Dialogs;
using VGAPainter.Data;
using System.Diagnostics;

namespace VGAPainter.Importers
{
    public class ImporterOptimised
    {
        CharBitmap targetBitmap;
        Bitmap sourceBitmap;

        BackgroundWorker worker = new BackgroundWorker();
        ProgressBox progressBox = new ProgressBox();

        ImporterGenericArgs args = new ImporterGenericArgs();

        public ImporterOptimised(Bitmap bitmap)
        {
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_Completed;
            worker.WorkerSupportsCancellation = true;

            sourceBitmap = bitmap;
            targetBitmap = new CharBitmap(bitmap.Width, bitmap.Height);

            progressBox.Text = "Importing bitmap...";
            progressBox.Value = 0;
            progressBox.FormClosing += ProgressBox_FormClosing;
        }

        public static CharBitmap Import(Bitmap bitmap)
        {
            // create importer instance
            var importer = new ImporterOptimised(bitmap);

            // show a progress bar while thing is being worked on (and wait for close)
            importer.worker.RunWorkerAsync();
            importer.progressBox.ShowDialog();

            // hide the progress box and return the image
            return importer.targetBitmap;
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // make things more accessible
            var source = this.sourceBitmap;
            var target = this.targetBitmap;
            var width = this.targetBitmap.Width;
            var height = this.targetBitmap.Height;

            // limit the rate of updates
            var update = 0;
            var updateModulo = targetBitmap.Length / 10;
            if (updateModulo > 32) updateModulo = 32;

            // fire an initial update
            {
                var status = new ImporterStatus(0, target.Length);
                worker.ReportProgress(status.PercentInt, status);
            }

            // get to work
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Result = false;
                        e.Cancel = true;
                        return;
                    }

                    Color thisColor = source.GetPixel(x, y);
                    if (update++ >= updateModulo)
                    {
                        var status = new ImporterStatus(y * width + x, target.Length);
                        worker.ReportProgress(status.PercentInt, status);

                        update = 0;
                    }

                    if (thisColor.A == 0)
                    {
                        target.Data[y * width + x] = 0x00;
                        continue;
                    }

                    // get hsv values for current color
                    double h, s, v;
                    Palette.ToHsv(thisColor, out h, out s, out v);

                    // catch black and white
                    if (v == 0)
                    {
                        target.SetPixel(x, y, 0);
                        continue;
                    }
                    if (s == 0 && v == 1)
                    {
                        target.SetPixel(x, y, 15);
                        continue;
                    }

                    // deal with greyscale first
                    if (s < 0.125)
                    {
                        byte color = (byte)(16 + v * 16);
                        target.SetPixel(x, y, color);
                        continue;
                    }
                    Debug.Assert(s >= 0.125, "Saturation must be over 0.125.", "Saturation is " + s.ToString());

                    // palette indeces
                    int hueIndex, satIndex, lumIndex;

                    // adjust hue to start from blue and assign index
                    h -= 240;
                    if (h < 0) h = 360 + h;
                    hueIndex = (int)(h / 15);

                    // determine saturation and luminance
                    satIndex = 0;                       // full sat
                    if (s <= 0.5) satIndex = 1;         // half sat
                    else if (s <= 0.25) satIndex = 2;   // quarter sat
                    lumIndex = 0;
                    if (v <= 0.5) lumIndex = 1;
                    else if (v <= 0.25) lumIndex = 2;

                    // calculate the pallete entry location
                    byte paletteEntry = (byte)(32 + lumIndex * 72 + satIndex * 24 + hueIndex);
                    target.SetPixel(x, y, paletteEntry);
                }
        }

        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // update the progress bar
            progressBox.Maximum = 100;
            progressBox.Value = e.ProgressPercentage;
            progressBox.ProgressText = e.UserState.ToString();
        }

        void Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            // hide the progress box
            progressBox.Close();
        }

        void ProgressBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            // closing the window implies cancellation
            if (worker.IsBusy)
            {
                targetBitmap = null;
                worker.CancelAsync();
                GC.Collect();
            }
        }
    }
}
