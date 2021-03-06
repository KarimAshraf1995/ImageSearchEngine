﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void done()
        {
            StartButton.Text = "Start";
            started = false;
            ImageLocation.Enabled = true;
            ImageSetLocation.Enabled = true;
            ImageBrowse_button.Enabled = true;
            FolderBrowse_button.Enabled = true;
        }
        public void ImageCompared(string image, double score)
        {
            MatchedBox1.ImageLocation = image;
            MatchAcc.Text = score.ToString("P2");
        }

        public void FinalMatch(string image, string guess, double score)
        {
            MatchedBox1.ImageLocation = image;
            MatchAcc.Text = score.ToString("P2");
            guessLabel.Text = guess;
            done();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            guessLabel.Text = "";
            if (!started)
            {
                ImageLocation.Enabled = false;
                ImageSetLocation.Enabled = false;
                ImageBrowse_button.Enabled = false;
                FolderBrowse_button.Enabled = false;
                StartButton.Text = "Stop";
                started = true;
                new Task(() => { SearchOperation.StartOperation(this, ImageLocation.Text, ImageSetLocation.Text); }).Start();
            }
            else
            {
                SearchOperation.cancelled = true;
                done();
            }
        }

        private void ImageLocation_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(ImageLocation.Text))
            {
                OriginalpictureBox.ImageLocation = ImageLocation.Text;
                ImageLocation.BackColor = Color.White;
                if(Directory.Exists(ImageSetLocation.Text))
                    StartButton.Enabled = true;
                else
                    StartButton.Enabled = false;
            }
            else
            {
                OriginalpictureBox.ImageLocation = null;
                ImageLocation.BackColor = Color.LightPink;
                StartButton.Enabled = false;
            }
        }

        private void ImageSetLocation_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(ImageSetLocation.Text))
            {
                ImageSetLocation.BackColor = Color.White;
                if (File.Exists(ImageLocation.Text))
                    StartButton.Enabled = true;
                else
                    StartButton.Enabled = false;
            }
            else
            {
                ImageSetLocation.BackColor = Color.LightPink;
                StartButton.Enabled = false;
            }
        }
    }
}
