using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SvgGenerator
{
    public class Circle : Shape
    {
        private readonly string CIRC_TEMPLATE = "<circle cx='{0}' cy='{1}' r='{2}' style='fill:rgb({3},{4},{5})' />";

        public Circle(Color color, int cx, int cy, int radius)
            : base(color, cx, cy, radius) { }

        public Circle()
            : base() { }
        public override string BuildSVGString(bool noise)
        {
            if(noise)
            {
                var NoiseAdder = new AddNoise();
                color = NoiseAdder.NoisifyColor(color);
                return String.Format(CIRC_TEMPLATE, NoiseAdder.NoisifyPosition(X), NoiseAdder.NoisifyPosition(Y),
                    Size, color.R, color.G, color.B);
            }
            else
            {
                return String.Format(CIRC_TEMPLATE, X, Y, Size, color.R, color.G, color.B);
            }
        }

    }
}
