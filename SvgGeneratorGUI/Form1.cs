using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SvgGenerator;

namespace SvgGeneratorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateSvgBtn_Click(object sender, EventArgs e)
        {
            var fileName = FileNameTextBox.Text + ".svg";
            bool doesHaveNoise = NoiseCheckBox.Checked;
            var svgBuilder = new SvgBuilder();
            var myFileCreator = new FileCreator();
            var Shapelist = new List<Shape>();
            if (InputFromFileOrUserComboBox.SelectedIndex == 0)
            {
                GenerateSvgFromFile(Shapelist, myFileCreator, fileName, svgBuilder, doesHaveNoise);
            }
            else
            {
                GenerateSvgFromInputBox(Shapelist, myFileCreator, fileName, svgBuilder, doesHaveNoise);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setVisibilityBoxes(false);
        }

        private void InputFromFileOrUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputFromFileOrUserComboBox.SelectedIndex == 0)
            {
                InputFile();
            }
            else
            {
                InputManual();
            }
        }

        private void Preset1Button_Click(object sender, EventArgs e)
        {
            InputFromTextBox.Text = "Red Circle, Blue Square, Green Square, " +
                "Orange Circle, Purple Circle";
        }

        private void Preset2Button_Click(object sender, EventArgs e)
        {
            InputFromTextBox.Text = "PowderBlue Square, PeachPuff Circle, PapayaWhip Square, " +
                "Orchid Square, MintyRose Circle";
        }

        private void Preset3Button_Click(object sender, EventArgs e)
        {
            InputFromTextBox.Text = "LimeGreen Square, LightPink Circle, LightGoldenrodYellow Circle, " +
                "Ivory Square, Lavender Circle";
        }

        private void RandomColorButton_Click(object sender, EventArgs e)
        {
            InputFromTextBox.Text = "";
            Random rnd = new Random();
            int numOfLoops = rnd.Next(5, 10);
            for (int i = 0; i < numOfLoops; i++)
            {
                InputFromTextBox.Text += getRandColor() + " " + getRandShape();
                if (i != numOfLoops - 1)
                {
                    InputFromTextBox.Text += ", ";
                }
            }
        }

        private string getRandColor()
        {
            Array colorsArray = Enum.GetValues(typeof(KnownColor));
            KnownColor[] allColors = new KnownColor[colorsArray.Length];
            Array.Copy(colorsArray, allColors, colorsArray.Length);
            Random rnd = new Random();
            string colorString = allColors[rnd.Next(28, 167)].ToString();
            return colorString;
        }

        private string getRandShape()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 2);
            if (number == 1)
            {
                return "Circle";
            }
            else
            {
                return "Square";
            }
        }

        private void setVisibilityBoxes(bool True)
        {
            if(True)
            {
                Preset1Button.Visible = true;
                Preset2Button.Visible = true;
                Preset3Button.Visible = true;
                RandomColorButton.Visible = true;
                InputFromTextBox.Visible = true;
            }
            else
            {
                InputFromTextBox.Visible = false;
                Preset1Button.Visible = false;
                Preset2Button.Visible = false;
                Preset3Button.Visible = false;
                RandomColorButton.Visible = false;
            }
        }

        private void InputFile()
        {
            setVisibilityBoxes(false);
            InputFromTextBox.Visible = true;
            label4.Text = " ";
            InputFromTextBox.Text = "";
            label3.Text = "Input File Name";
            InputFromTextBox.AcceptsReturn = false;
            InputFromTextBox.AcceptsTab = false;
            InputFromTextBox.Multiline = false;
            InputFromTextBox.ScrollBars = ScrollBars.None;
            InputFromTextBox.Height = 20;
        }

        private void InputManual()
        {
            setVisibilityBoxes(true);
            label4.Text = " ";
            InputFromTextBox.Text = "";
            label3.Text = "Color and Shape";
            InputFromTextBox.AcceptsReturn = true;
            InputFromTextBox.AcceptsTab = true;
            InputFromTextBox.Multiline = true;
            InputFromTextBox.ScrollBars = ScrollBars.Vertical;
            InputFromTextBox.Height = 200;
            InputFromTextBox.Text = "<Color> <Shape>, <Color> <Shape>";
        }

        private void GenerateSvgFromFile(List<Shape> Shapelist, FileCreator textFile, String fileName,
            SvgBuilder svgBuilder, bool doesHaveNoise)
        {
            var FileReader = new FileReader();
            Shapelist = FileReader.ReadFile(InputFromTextBox.Text);
            textFile.Create(fileName, svgBuilder.Build(Shapelist, doesHaveNoise));
            label4.Text = "SVG File Generated";
        }

        private void GenerateSvgFromInputBox(List<Shape> Shapelist, FileCreator textFile, String fileName,
            SvgBuilder svgBuilder, bool doesHaveNoise)
        {
            string[] ColorAndShape = InputFromTextBox.Text.Split(", ");
            for (int i = 0; i < ColorAndShape.Length; i++)
            {
                string[] ColorOrShape = ColorAndShape[i].Split(" ");
                Color color = Color.FromName(ColorOrShape[0]);
                var shape = ColorOrShape[1];
                Shapelist.Add(GetUserInput.AddShape(i, color, shape, 200, 100));
            }
            textFile.Create(fileName, svgBuilder.Build(Shapelist, doesHaveNoise));
            label4.Text = "SVG File Generated";
        }
    }
}
