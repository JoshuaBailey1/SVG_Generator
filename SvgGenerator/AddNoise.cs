using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SvgGenerator
{
    class AddNoise
    {
        public Color NoisifyColor(Color color)
        {
            return Color.FromArgb(RandomizeColor(color.R), RandomizeColor(color.G), RandomizeColor(color.B));
        }
        private int RandomizeColor(int color)
        {
            Random rnd = new Random();
            int OriginalColor = color;
            do
            {
                color = OriginalColor + rnd.Next(-7, 7);
            }
            while (color < 0 || color > 255);
            return color;
        }

        public int NoisifyPosition(int position)
        {
            return RandomizePosition(position); ;
        }

        private int RandomizePosition(int position)
        {
            int OriginalPosition = position;
            Random rnd = new Random();
            do
            {
                position = OriginalPosition + rnd.Next(-1, 1);
            }
            while (position < 0);
            return position;
        }
    }
}
