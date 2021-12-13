using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace SvgGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new GetUserInput();
            var fileName = userInput.GetFileName();
            var doesHaveNoise = userInput.GetNoisePreference();
            var textFile = new FileCreator();
            var svgBuilder = new SvgBuilder();
            var shapeList = userInput.CustomizeShapes();
            textFile.Create(fileName, svgBuilder.Build(shapeList, doesHaveNoise));
            /*
            //This is simply so I can debug easier
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", @"
                file:///C:/Users/Joshua%20Bailey/source/repos/SvgGenerator_bailey/SvgGenerator/bin/Debug/netcoreapp3.1/" + fileName);
            */
        }
    }
}
