using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSearchEngine
{
    public partial class GUI : Form
    {
        private bool started = false;
        public GUI()
        {
            InitializeComponent();
        }

        private void ImageBrowse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Filter = "JPEG files|*.jpg|PNG files|*.png";
            dialog.Title = "Select Image";
            if ((dialog.ShowDialog()) == DialogResult.OK)
            {
                ImageLocation.Text = dialog.FileName;
            }
        }

        private void FolderBrowse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select Folder";


            if ((dialog.ShowDialog()) == DialogResult.OK)
            {
                ImageSetLocation.Text = dialog.SelectedPath;
            }
        }

        private void ImageLoad_button_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ImageLocation.Text))
            {
                OriginalpictureBox.ImageLocation = ImageLocation.Text;
            }
            else
            {
                MessageBox.Show("Invalid file location");
            }
        }
        private void done()
        {
            StartButton.Text = "Start";
            started = false;
            ImageLocation.Enabled = true;
            ImageSetLocation.Enabled = true;
            ImageLoad_button.Enabled = true;
            FolderLoad_button.Enabled = true;
        }
        public void ImageCompared(string image, double score)
        {
            MatchedBox1.ImageLocation = ImageSetLocation + "/" + image;
            MatchAcc.Text = score.ToString("P2");
        }

        public void FinalMatch(string image,string guess,double score)
        {
            MatchedBox1.ImageLocation = ImageSetLocation + "/" + image;
            MatchAcc.Text = score.ToString("P2");
            guessLabel.Text = guess;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                ImageLocation.Enabled = false;
                ImageSetLocation.Enabled = false;
                ImageLoad_button.Enabled = false;
                FolderLoad_button.Enabled = false;
                StartButton.Text = "Stop";
                started = true;
            }
            else
            {

                done();
            }
        }
    }
}
