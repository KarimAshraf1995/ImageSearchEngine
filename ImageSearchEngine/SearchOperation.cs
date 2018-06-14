﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageSearchEngine
{
    class SearchOperation
    {
        public static bool cancelled = false;

        public static void StartOperation(GUI gui, string image, string set_path)
        {
            if (!Directory.Exists(set_path))
                return;
            if (!File.Exists(image))
                return;
            cancelled = false;
            const int common_width = 256;
            Dictionary<string, string> labels = new Dictionary<string, string>();
            double[] image_descriptor = ImageOperations.LBP_Descriptor(ImageOperations.rgb2gray(ImageOperations.Resize(common_width, new System.Drawing.Bitmap(image))));
            double[] other_image;
            double max_score = 0, score = 0;
            string max_score_file = "", guess = "";

            foreach (string filename in Directory.EnumerateFiles(set_path, "*.csv"))
            {
                labels = GetSetLabels(filename);
            }
            foreach (string filename in Directory.EnumerateFiles(set_path, "*.jpg"))
            {
                other_image = ImageOperations.LBP_Descriptor(ImageOperations.rgb2gray(ImageOperations.Resize(common_width, new System.Drawing.Bitmap(filename))));
                score = ImageOperations.dotProduct(image_descriptor, other_image);
                if (cancelled) return;
                gui.Invoke(new Action<string, double>(gui.ImageCompared), filename, score);
                if (score > max_score)
                {
                    max_score = score;
                    max_score_file = filename;
                }
            }
            foreach (string filename in Directory.EnumerateFiles(set_path, "*.png"))
            {
                other_image = ImageOperations.LBP_Descriptor(ImageOperations.rgb2gray(ImageOperations.Resize(common_width,new System.Drawing.Bitmap(filename))));
                score = ImageOperations.dotProduct(image_descriptor, other_image);
                if (cancelled) return;
                gui.Invoke(new Action<string, double>(gui.ImageCompared), filename, score);
                if (score > max_score)
                {
                    max_score = score;
                    max_score_file = filename;
                }
            }

            if (labels.ContainsKey(Path.GetFileName(max_score_file)))
                guess = labels[Path.GetFileName(max_score_file)];
            gui.Invoke(new Action<string, string, double>(gui.FinalMatch), max_score_file, guess, max_score);

        }

        public static Dictionary<string, string> GetSetLabels(string filename)
        {
            Dictionary<string, string> labels = new Dictionary<string, string>();
            return labels;
        }
    }
}