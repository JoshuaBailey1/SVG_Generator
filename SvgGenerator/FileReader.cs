using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace SvgGenerator
{
    public class FileReader
    {
        public List<Shape> ReadFile(string fileName)
        {
            var shapeList = new List<Shape>();
            var fullFilePath = Path.GetFullPath(fileName);
            string[] lines = File.ReadAllLines(fullFilePath);
            return SplitLinesByCommas(shapeList, lines);
        }

        private List<Shape> SplitLinesByCommas(List<Shape> shapeList, string[] fileLines)
        {
            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] linesSplit = fileLines[i].Split(", ");
                AddToShapeList(shapeList, linesSplit);
            }
            return shapeList;
        }

        private List<Shape> AddToShapeList(List<Shape> shapeList, string[] linesSplit)
        {
            const int SquareSize = 50;
            const int CircleSize = SquareSize/2;
            if (linesSplit[3] == "Square")
            {
                shapeList.Add(new Square(Color.FromName(linesSplit[2]), int.Parse(linesSplit[0]) * SquareSize, +
                    int.Parse(linesSplit[1]) * SquareSize, SquareSize));
            }
            else if (linesSplit[3] == "Circle")
            {
                shapeList.Add(new Circle(Color.FromName(linesSplit[2]), int.Parse(linesSplit[0]) * SquareSize + CircleSize, +
                    int.Parse(linesSplit[1]) * SquareSize + CircleSize, CircleSize));
            }
            else
            {
                throw new Exception();
            }
            return shapeList;
        }
    }
}
