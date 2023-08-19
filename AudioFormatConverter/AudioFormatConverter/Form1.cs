using NAudio.Wave;
using NAudio.Lame;
using NVorbis;
using NAudio.Vorbis;
using System.Diagnostics;
using NVorbis.Contracts;

namespace AudioFormatConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectAudioFormatComboBox.Items.Add("WAV");
            selectAudioFormatComboBox.Items.Add("MP3");
            selectAudioFormatComboBox.Items.Add("OGG");
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectAudioFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.ogg|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected file's path in a label or textbox
                selectFileLabel.Text = openFileDialog.FileName;
            }
        }

        private void startConversionButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectFileLabel.Text) && !string.IsNullOrEmpty(selectAudioFormatComboBox.Text))
            {
                var sourceFile = selectFileLabel.Text;
                var targetFormat = selectAudioFormatComboBox.Text;
                var outputFilePath = $"{System.IO.Path.GetDirectoryName(sourceFile)}\\{System.IO.Path.GetFileNameWithoutExtension(sourceFile) + " " + targetFormat.ToString()}.{targetFormat.ToLower()}";

                using (var reader = new AudioFileReader(sourceFile))
                {
                    if (targetFormat.ToLower() == "wav")
                    {
                        using (var writer = new WaveFileWriter(outputFilePath, reader.WaveFormat))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;

                            while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                writer.Write(buffer, 0, bytesRead);
                                UpdateProgressBar(reader);
                            }
                        }
                    }
                    else if (targetFormat.ToLower() == "mp3")
                    {
                        using (var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, LAMEPreset.VBR_50))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;

                            while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                writer.Write(buffer, 0, bytesRead);
                                UpdateProgressBar(reader);
                            }
                        }
                    }
                    else if (targetFormat.ToLower() == "ogg")
                    {
                        using (var writer = new WaveFileWriter(outputFilePath, reader.WaveFormat))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;

                            while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                writer.Write(buffer, 0, bytesRead);
                                UpdateProgressBar(reader);
                            }
                        }
                    }
                }

                MessageBox.Show("Conversion completed.");

                // Open the destination folder in the default file explorer
                string destinationFolder = System.IO.Path.GetDirectoryName(outputFilePath);
                Process.Start("explorer.exe", destinationFolder);

                // Reset the progress bar
                conversionProgressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("Please select a source audio file and a target format.");
            }
        }

        private void UpdateProgressBar(AudioFileReader reader)
        {
            double percentage = (double)reader.Position / reader.Length;
            int progressBarValue = (int)(percentage * 100);
            conversionProgressBar.Value = progressBarValue;
        }

        private void conversionProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectAudioFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}