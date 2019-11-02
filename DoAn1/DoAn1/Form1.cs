using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAn1
{
    public partial class Form1 : Form
    {
        Graphics grs;
        public object panel;
        public Form1()
        {
            InitializeComponent();

            grs = panel1.CreateGraphics();
            
        }
       
        private async void btn1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader rd = new StreamReader(ofd.FileName))
                    {
                        richTextBox1.Text = await rd.ReadToEndAsync();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            draw draw = new draw();
            draw.drawing(panel1);
            draw.drawing1(panel1);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //int x = e.X;
            //int y = e.Y;
            //if (x <= 130 & x >= 60 )
            //{
            //    if (y >= 40 & y <= 70)
            //    {
            //        label1.Text = "Conv2d(3, 64, kernel_size=11, stride=4, padding=2)";
            //    }
            //    if (y >= 100 & y <= 130)
            //    {
            //        label1.Text = "Dropout(3, 64, p=abc, inplace=false)";
            //    }
            //    if (y >= 160 & y <= 190)
            //    {
            //        label1.Text = "Linear(5, 77, input_features=2, output_features=4, bias=true)";
            //    }
            //}
            //else
            //    label1.Text = "";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader rd = new StreamReader(ofd.FileName))
                    {
                        string currentLine;
                        string searchString = "data";
                        string searchString1 = "Conv2d";
                        string searchString2 = "AvgPool2d";
                        string searchString3 = "BatchNorm2d";
                        string searchString4 = "Dropout";
                        string searchString5 = "MaxPool2d";
                        string searchString6 = "Softmax";

                        string success = "Yes";
                        string error = "Nope";
                        bool foundText = false;

                        do
                        {
                            currentLine = rd.ReadLine();
                            if (currentLine != null)
                            {
                                foundText = currentLine.Contains(searchString);
                                foundText = currentLine.Contains(searchString1);
                                foundText = currentLine.Contains(searchString2);
                                foundText = currentLine.Contains(searchString3);
                                foundText = currentLine.Contains(searchString4);
                                foundText = currentLine.Contains(searchString5);
                                foundText = currentLine.Contains(searchString6);
                            }
                        }
                        while (currentLine != null && !foundText);

                        if (foundText)
                        {
                            MessageBox.Show(success);
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }

<<<<<<< HEAD
=======
                    }
                }
            }
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            draw draw = new draw();
            draw.drawing(panel1);
>>>>>>> 81f2f8834ebea052ee1e14ca6d7a4a6c3cc5e1bf
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (x <= 130 & x >= 60)
            {
                if (y >= 40 & y <= 70)
                {
                    label1.Text = "Conv2d(3, 64, kernel_size=11, stride=4, padding=2)";
                }
                if (y >= 100 & y <= 130)
                {
                    label1.Text = "Dropout(3, 64, p=abc, inplace=false)";
                }
                if (y >= 160 & y <= 190)
                {
                    label1.Text = "Linear(5, 77, input_features=2, output_features=4, bias=true)";
                }
            }
            else
                label1.Text = "";
        }
    }
}
