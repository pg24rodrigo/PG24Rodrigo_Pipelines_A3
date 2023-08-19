namespace AudioFormatConverter
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
            selectAudioFileButton = new Button();
            selectAudioFormatComboBox = new ComboBox();
            startConversionButton = new Button();
            conversionProgressBar = new ProgressBar();
            welcomeLabel = new Label();
            selectFileLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // selectAudioFileButton
            // 
            selectAudioFileButton.Location = new Point(194, 226);
            selectAudioFileButton.Name = "selectAudioFileButton";
            selectAudioFileButton.Size = new Size(184, 23);
            selectAudioFileButton.TabIndex = 1;
            selectAudioFileButton.Text = "Select File";
            selectAudioFileButton.UseVisualStyleBackColor = true;
            selectAudioFileButton.Click += selectAudioFileButton_Click;
            // 
            // selectAudioFormatComboBox
            // 
            selectAudioFormatComboBox.FormattingEnabled = true;
            selectAudioFormatComboBox.Location = new Point(400, 151);
            selectAudioFormatComboBox.Name = "selectAudioFormatComboBox";
            selectAudioFormatComboBox.Size = new Size(121, 23);
            selectAudioFormatComboBox.TabIndex = 2;
            selectAudioFormatComboBox.SelectedIndexChanged += selectAudioFormatComboBox_SelectedIndexChanged;
            // 
            // startConversionButton
            // 
            startConversionButton.Location = new Point(384, 226);
            startConversionButton.Name = "startConversionButton";
            startConversionButton.Size = new Size(137, 23);
            startConversionButton.TabIndex = 3;
            startConversionButton.Text = "Convert!";
            startConversionButton.UseVisualStyleBackColor = true;
            startConversionButton.Click += startConversionButton_Click;
            // 
            // conversionProgressBar
            // 
            conversionProgressBar.Location = new Point(194, 255);
            conversionProgressBar.Name = "conversionProgressBar";
            conversionProgressBar.Size = new Size(327, 23);
            conversionProgressBar.TabIndex = 4;
            conversionProgressBar.Click += conversionProgressBar_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(231, 116);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(262, 15);
            welcomeLabel.TabIndex = 5;
            welcomeLabel.Text = "Welcome to my Audio File Conversion Program!";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // selectFileLabel
            // 
            selectFileLabel.AutoSize = true;
            selectFileLabel.Location = new Point(194, 192);
            selectFileLabel.Name = "selectFileLabel";
            selectFileLabel.Size = new Size(119, 15);
            selectFileLabel.TabIndex = 6;
            selectFileLabel.Text = "Your audio file path...";
            selectFileLabel.Click += selectFileLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 154);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 7;
            label1.Text = "Select an audio format to convert to:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(selectFileLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(conversionProgressBar);
            Controls.Add(startConversionButton);
            Controls.Add(selectAudioFormatComboBox);
            Controls.Add(selectAudioFileButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectAudioFileButton;
        private ComboBox selectAudioFormatComboBox;
        private Button startConversionButton;
        private ProgressBar conversionProgressBar;
        private Label welcomeLabel;
        private Label selectFileLabel;
        private Label label1;
    }
}