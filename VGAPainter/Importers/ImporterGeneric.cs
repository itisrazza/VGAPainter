using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VGAPainter.Dialogs;
using VGAPainter.Data;

namespace VGAPainter.Importers
{
    public class ImporterGenericArgs
    {
        public Palette Palette { get; set; }

        public int DitherLevel { get; set; }

        public ImporterGenericArgs()
        {
            Palette = Palette.VGA;
            DitherLevel = 0;
        }
    }

    public class ImporterGeneric
    {
        CharBitmap targetBitmap;
        Bitmap sourceBitmap;

        BackgroundWorker worker = new BackgroundWorker();
        ProgressBox progressBox = new ProgressBox();

        ImporterGenericArgs args = new ImporterGenericArgs();

        public ImporterGeneric(Bitmap bitmap, ImporterGenericArgs args)
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

        public static CharBitmap Import(Bitmap bitmap, ImporterGenericArgs args = null)
        {
            // create importer instance
            var importer = new ImporterGeneric(bitmap, args);

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

                    int minIndex = -1, min = int.MaxValue;
                    int[] overallDiff = new int[Palette.Length];
                    for (int i = 0; i < overallDiff.Length; i++)
                    {
                        Color vgaColor = args.Palette[i];
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
                    target.Data[y * width + x] = (byte)minIndex;
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
