using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGAPainter.Data
{
    /// <summary>
    /// A character-based (256 colour palette) bitmap image
    /// </summary>
    public class CharBitmap
    {
        /// <summary>
        /// Raw bitmap data array
        /// </summary>
        public byte[] Data { get; protected set; }

        /// <summary>
        /// Bitmap width
        /// </summary>
        public int Width { get; protected set; }

        /// <summary>
        /// Bitmap height
        /// </summary>
        public int Height { get => Data.Length / Width; }

        /// <summary>
        /// Data size
        /// </summary>
        public int Length { get => Data.Length; }

        public CharBitmap(int width, int height)
        {
            // allocate char array
            Data = new byte[width * height];
            Width = width;
        }

        public CharBitmap(byte[] data, int width)
        {
            // create bitmap from existing data
            Data = data;
            Width = width;
        }

        public int GetOffset(int x, int y)
        {
            return y * Width + x;
        }

        public byte GetPixel(int x, int y)
        {
            return Data[GetOffset(x, y)];
        }

        public void SetPixel(int x, int y, byte colour)
        {
            Data[GetOffset(x, y)] = colour;
        }
    }
}
