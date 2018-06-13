namespace ImageSearchEngine
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageLocation = new System.Windows.Forms.TextBox();
            this.ImageSetLocation = new System.Windows.Forms.TextBox();
            this.ImageBrowse_button = new System.Windows.Forms.Button();
            this.ImageLoad_button = new System.Windows.Forms.Button();
            this.FolderLoad_button = new System.Windows.Forms.Button();
            this.FolderBrowse_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OriginalpictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MatchAcc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MatchedBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalpictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchedBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ImageSet";
            // 
            // ImageLocation
            // 
            this.ImageLocation.Location = new System.Drawing.Point(80, 13);
            this.ImageLocation.Name = "ImageLocation";
            this.ImageLocation.Size = new System.Drawing.Size(656, 20);
            this.ImageLocation.TabIndex = 2;
            // 
            // ImageSetLocation
            // 
            this.ImageSetLocation.Location = new System.Drawing.Point(80, 48);
            this.ImageSetLocation.Name = "ImageSetLocation";
            this.ImageSetLocation.Size = new System.Drawing.Size(656, 20);
            this.ImageSetLocation.TabIndex = 3;
            // 
            // ImageBrowse_button
            // 
            this.ImageBrowse_button.Location = new System.Drawing.Point(750, 13);
            this.ImageBrowse_button.Name = "ImageBrowse_button";
            this.ImageBrowse_button.Size = new System.Drawing.Size(75, 23);
            this.ImageBrowse_button.TabIndex = 4;
            this.ImageBrowse_button.Text = "Browse";
            this.ImageBrowse_button.UseVisualStyleBackColor = true;
            this.ImageBrowse_button.Click += new System.EventHandler(this.ImageBrowse_button_Click);
            // 
            // ImageLoad_button
            // 
            this.ImageLoad_button.Location = new System.Drawing.Point(831, 13);
            this.ImageLoad_button.Name = "ImageLoad_button";
            this.ImageLoad_button.Size = new System.Drawing.Size(75, 23);
            this.ImageLoad_button.TabIndex = 5;
            this.ImageLoad_button.Text = "Load";
            this.ImageLoad_button.UseVisualStyleBackColor = true;
            this.ImageLoad_button.Click += new System.EventHandler(this.ImageLoad_button_Click);
            // 
            // FolderLoad_button
            // 
            this.FolderLoad_button.Location = new System.Drawing.Point(831, 46);
            this.FolderLoad_button.Name = "FolderLoad_button";
            this.FolderLoad_button.Size = new System.Drawing.Size(75, 23);
            this.FolderLoad_button.TabIndex = 7;
            this.FolderLoad_button.Text = "Load";
            this.FolderLoad_button.UseVisualStyleBackColor = true;
            // 
            // FolderBrowse_button
            // 
            this.FolderBrowse_button.Location = new System.Drawing.Point(750, 46);
            this.FolderBrowse_button.Name = "FolderBrowse_button";
            this.FolderBrowse_button.Size = new System.Drawing.Size(75, 23);
            this.FolderBrowse_button.TabIndex = 6;
            this.FolderBrowse_button.Text = "Browse";
            this.FolderBrowse_button.UseVisualStyleBackColor = true;
            this.FolderBrowse_button.Click += new System.EventHandler(this.FolderBrowse_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guessLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 73);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best Guess";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.Location = new System.Drawing.Point(473, 26);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(0, 31);
            this.guessLabel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(927, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OriginalpictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 408);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Image";
            // 
            // OriginalpictureBox
            // 
            this.OriginalpictureBox.Location = new System.Drawing.Point(6, 48);
            this.OriginalpictureBox.Name = "OriginalpictureBox";
            this.OriginalpictureBox.Size = new System.Drawing.Size(498, 351);
            this.OriginalpictureBox.TabIndex = 10;
            this.OriginalpictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MatchAcc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.MatchedBox1);
            this.groupBox3.Location = new System.Drawing.Point(543, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 407);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // MatchAcc
            // 
            this.MatchAcc.AutoSize = true;
            this.MatchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchAcc.Location = new System.Drawing.Point(442, 16);
            this.MatchAcc.Name = "MatchAcc";
            this.MatchAcc.Size = new System.Drawing.Size(0, 25);
            this.MatchAcc.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Matched Image";
            // 
            // MatchedBox1
            // 
            this.MatchedBox1.Location = new System.Drawing.Point(5, 48);
            this.MatchedBox1.Name = "MatchedBox1";
            this.MatchedBox1.Size = new System.Drawing.Size(464, 351);
            this.MatchedBox1.TabIndex = 13;
            this.MatchedBox1.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FolderLoad_button);
            this.Controls.Add(this.FolderBrowse_button);
            this.Controls.Add(this.ImageLoad_button);
            this.Controls.Add(this.ImageBrowse_button);
            this.Controls.Add(this.ImageSetLocation);
            this.Controls.Add(this.ImageLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1041, 624);
            this.MinimumSize = new System.Drawing.Size(1041, 624);
            this.Name = "GUI";
            this.Text = "LBP Image Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalpictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchedBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImageLocation;
        private System.Windows.Forms.TextBox ImageSetLocation;
        private System.Windows.Forms.Button ImageBrowse_button;
        private System.Windows.Forms.Button ImageLoad_button;
        private System.Windows.Forms.Button FolderLoad_button;
        private System.Windows.Forms.Button FolderBrowse_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox OriginalpictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MatchAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox MatchedBox1;
    }
}

