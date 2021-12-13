using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SvgGenerator
{
    public class Square : Shape
    {
        private readonly string RECT_TEMPLATE = "<rect width='{0}' height='{1}' x='{2}' y='{3}' style='fill:rgb({4},{5},{6})' />";

        public Square(Color color, int x, int y, int size)
            : base(color, x, y, size) { }

        public Square()
            : base() { }
        public override string BuildSVGString(bool noise)
        {
            if(noise)
            {
                var NoiseAdder = new AddNoise();
                color = NoiseAdder.NoisifyColor(color);
                return String.Format(RECT_TEMPLATE, Size, Size, NoiseAdder.NoisifyPosition(X), NoiseAdder.NoisifyPosition(Y),
                    color.R, color.G, color.B);
            }
            else
            {
                return String.Format(RECT_TEMPLATE, Size, Size, X, Y, color.R, color.G, color.B);
            }

        }

    }
}

