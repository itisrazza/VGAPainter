using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGAPainter.Data
{
    public struct ImporterStatus
    {
        public int Progress { get; private set; }
        public int Total { get; private set; }
        public bool BitmapRender { get; private set; }
        public int PercentInt { get => (int)(100 * Percent); }
        public decimal Percent { get => (decimal)Progress / Total; }

        public ImporterStatus(bool bitmap, int total)
        {
            BitmapRender = bitmap;
            Total = total;
            Progress = total;
        }

        public ImporterStatus(int progress, int total)
        {
            BitmapRender = false;
            Progress = progress;
            Total = total;
        }

        public override string ToString()
        {
            if (BitmapRender) return "Rendering bitmap...";
            return string.Format("{0} / {1} pixels processed", Progress, Total);
        }
    }
}
