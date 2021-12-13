using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SvgGenerator
{
    public class GetUserInput
    {
        public string GetFileName()
        {
            Console.Write("Enter File Name: ");
            return Console.ReadLine() + ".svg";
        }
        public List<Shape> CustomizeShapes()
        {
            Console.Write("Enter '1' for Input Via File, Otherwise Enter Any Key: ");
            var menu = Console.ReadLine();
            if (menu == "1")
            {
                return InputFromFile();
            }
            else
            {
                return TakeUserInput();
            }
        }

        private List<Shape> InputFromFile()
        {
            var FileReader = new FileReader();
            Console.Write("Enter Name Of File With Appropriate Extension: ");
            string fileName = Console.ReadLine();
            return FileReader.ReadFile(fileName);
        }

        public bool GetNoisePreference()
        {
            Console.Write("Enter '1' for Noise, Otherwise Enter Any Key: ");
            var input = Console.ReadLine();
            if (input == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private List<Shape> TakeUserInput()
        {
            var shapeList = new List<Shape>();
            const int SquareSize = 200;
            const int CircleSize = SquareSize / 2;
            Console.Write("How Many Shapes Would You Like?: ");
            var numOfShapes = Console.ReadLine();
            Console.WriteLine("Enter Color First, Then Shape (EX: Brown Circle)");
            for (int i = 0; i<int.Parse(numOfShapes); i++)
            {
                Console.Write("What Would You Like Shape" + (i+1) + " To Be? : ");
                string[] ColorAndShape = Console.ReadLine().Split(" ");
                Color color = Color.FromName(ColorAndShape[0]);
                var shape = ColorAndShape[1];
                Console.WriteLine();
                shapeList.Add(AddShape(i, color, shape, SquareSize, CircleSize));
            }
            return shapeList;
        }

        public static Shape AddShape(int i, Color color, string shape, int SquareSize, int CircleSize)
        {
            Shape NewShape;
            int SquareX = i * SquareSize;
            int SquareY = 0;
            int CircleCX = i * SquareSize + CircleSize;
            int CircleCY = CircleSize;
            if (shape == "Square" || shape == "square")
            {
                NewShape = new Square(color, SquareX, SquareY, SquareSize);
            }
            else if (shape == "Circle" || shape == "circle")
            {
                NewShape = new Circle(color, CircleCX, CircleCY, CircleSize);
            }
            else
            {
                throw new Exception();
            }
            return NewShape;
        }
    }
}