using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGAPainter
{
    class HistoryEvent
    {
        public ISet<PixelChange> changes { get; }

        public HistoryEvent(PixelChange singleChange)
        {
            changes = new HashSet<PixelChange>();
            changes.Add(singleChange);
        }

        public HistoryEvent(ISet<PixelChange> pixelChanges)
        {
            changes = pixelChanges;
        }
    }

    class PixelChange
    {
        public byte OldColor { get; }

        public byte NewColor { get; }

        public int Offset { get; }

        public PixelChange(int offset, byte oldColor, byte newColor)
        {
            this.Offset = offset;
            this.OldColor = oldColor;
            this.NewColor = newColor;
        }

        public int HashCode() => Offset << 16 | OldColor << 8 | NewColor;
    }
}
