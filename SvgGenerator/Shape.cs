using System.Drawing;

namespace SvgGenerator
{
    public abstract class Shape
    {
        public Color color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public Shape(Color color, int X, int Y, int Size)
        {
            this.color = color;
            this.X = X;
            this.Y = Y;
            this.Size = Size;
        }

        public Shape()
        { }

        public abstract string BuildSVGString(bool noise);

    }

}