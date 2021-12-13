
namespace SvgGeneratorGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateSvgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.NoiseCheckBox = new System.Windows.Forms.CheckBox();
            this.InputFromFileOrUserComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFromFileNameLabel = new System.Windows.Forms.Label();
            this.ReadFromFile = new System.Windows.Forms.Label();
            this.InputFromTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IsDoneLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Preset1Button = new System.Windows.Forms.Button();
            this.Preset2Button = new System.Windows.Forms.Button();
            this.Preset3Button = new System.Windows.Forms.Button();
            this.RandomColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateSvgBtn
            // 
            this.GenerateSvgBtn.Location = new System.Drawing.Point(12, 448);
            this.GenerateSvgBtn.Name = "GenerateSvgBtn";
            this.GenerateSvgBtn.Size = new System.Drawing.Size(1003, 51);
            this.GenerateSvgBtn.TabIndex = 0;
            this.GenerateSvgBtn.Text = "GenerateSVG";
            this.GenerateSvgBtn.UseVisualStyleBackColor = true;
            this.GenerateSvgBtn.Click += new System.EventHandler(this.GenerateSvgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SVG File Name";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(175, 30);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(373, 27);
            this.FileNameTextBox.TabIndex = 2;
            //this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // NoiseCheckBox
            // 
            this.NoiseCheckBox.AutoSize = true;
            this.NoiseCheckBox.Location = new System.Drawing.Point(175, 94);
            this.NoiseCheckBox.Name = "NoiseCheckBox";
            this.NoiseCheckBox.Size = new System.Drawing.Size(69, 24);
            this.NoiseCheckBox.TabIndex = 3;
            this.NoiseCheckBox.Text = "Noise";
            this.NoiseCheckBox.UseVisualStyleBackColor = true;
            // 
            // InputFromFileOrUserComboBox
            // 
            this.InputFromFileOrUserComboBox.FormattingEnabled = true;
            this.InputFromFileOrUserComboBox.Items.AddRange(new object[] {
            "File",
            "Manual"});
            this.InputFromFileOrUserComboBox.Location = new System.Drawing.Point(175, 146);
            this.InputFromFileOrUserComboBox.Name = "InputFromFileOrUserComboBox";
            this.InputFromFileOrUserComboBox.Size = new System.Drawing.Size(196, 28);
            this.InputFromFileOrUserComboBox.TabIndex = 4;
            this.InputFromFileOrUserComboBox.SelectedIndexChanged += new System.EventHandler(this.InputFromFileOrUserComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input From...";
            // 
            // InputFromFileNameLabel
            // 
            this.InputFromFileNameLabel.AutoSize = true;
            this.InputFromFileNameLabel.Location = new System.Drawing.Point(42, 231);
            this.InputFromFileNameLabel.Name = "InputFromFileNameLabel";
            this.InputFromFileNameLabel.Size = new System.Drawing.Size(0, 20);
            this.InputFromFileNameLabel.TabIndex = 6;
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.AutoSize = true;
            this.ReadFromFile.Location = new System.Drawing.Point(42, 231);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(0, 20);
            this.ReadFromFile.TabIndex = 7;
            // 
            // InputFromTextBox
            // 
            this.InputFromTextBox.Location = new System.Drawing.Point(280, 224);
            this.InputFromTextBox.Name = "InputFromTextBox";
            this.InputFromTextBox.Size = new System.Drawing.Size(268, 27);
            this.InputFromTextBox.TabIndex = 8;
            //this.InputFromTextBox.TextChanged += new System.EventHandler(this.InputFromTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(361, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 46);
            this.label4.TabIndex = 11;
            // 
            // Preset1Button
            // 
            this.Preset1Button.Location = new System.Drawing.Point(630, 224);
            this.Preset1Button.Name = "Preset1Button";
            this.Preset1Button.Size = new System.Drawing.Size(252, 26);
            this.Preset1Button.TabIndex = 12;
            this.Preset1Button.Text = "Preset1";
            this.Preset1Button.UseVisualStyleBackColor = true;
            this.Preset1Button.Click += new System.EventHandler(this.Preset1Button_Click);
            // 
            // Preset2Button
            // 
            this.Preset2Button.Location = new System.Drawing.Point(630, 271);
            this.Preset2Button.Name = "Preset2Button";
            this.Preset2Button.Size = new System.Drawing.Size(250, 25);
            this.Preset2Button.TabIndex = 13;
            this.Preset2Button.Text = "Preset2";
            this.Preset2Button.UseVisualStyleBackColor = true;
            this.Preset2Button.Click += new System.EventHandler(this.Preset2Button_Click);
            // 
            // Preset3Button
            // 
            this.Preset3Button.Location = new System.Drawing.Point(630, 312);
            this.Preset3Button.Name = "Preset3Button";
            this.Preset3Button.Size = new System.Drawing.Size(249, 28);
            this.Preset3Button.TabIndex = 14;
            this.Preset3Button.Text = "Preset3";
            this.Preset3Button.UseVisualStyleBackColor = true;
            this.Preset3Button.Click += new System.EventHandler(this.Preset3Button_Click);
            // 
            // RandomColorButton
            // 
            this.RandomColorButton.Location = new System.Drawing.Point(630, 356);
            this.RandomColorButton.Name = "RandomColorButton";
            this.RandomColorButton.Size = new System.Drawing.Size(246, 25);
            this.RandomColorButton.TabIndex = 15;
            this.RandomColorButton.Text = "Suprise Me!";
            this.RandomColorButton.UseVisualStyleBackColor = true;
            this.RandomColorButton.Click += new System.EventHandler(this.RandomColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 623);
            this.Controls.Add(this.RandomColorButton);
            this.Controls.Add(this.Preset3Button);
            this.Controls.Add(this.Preset2Button);
            this.Controls.Add(this.Preset1Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsDoneLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputFromTextBox);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.InputFromFileNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputFromFileOrUserComboBox);
            this.Controls.Add(this.NoiseCheckBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateSvgBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateSvgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.CheckBox NoiseCheckBox;
        private System.Windows.Forms.ComboBox InputFromFileOrUserComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InputFromFileNameLabel;
        private System.Windows.Forms.Label ReadFromFile;
        private System.Windows.Forms.TextBox InputFromTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IsDoneLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Preset1Button;
        private System.Windows.Forms.Button Preset2Button;
        private System.Windows.Forms.Button Preset3Button;
        private System.Windows.Forms.Button RandomColorButton;
    }
}

