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
        private object uc_Module1;
        public Form1()
        {
            InitializeComponent();
            grs = panel1.CreateGraphics();
        }
       
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {   //Search character in txt file
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader rd = new StreamReader(ofd.FileName))
                    {
                        string currentLine;
                        string searchString = "def forward(self,data)";
                        string searchString1 = "Conv2d";
                        //string searchString2 = "AvgPool2d";
                        //string searchString3 = "BatchNorm2d";
                        //string searchString4 = "Dropout";
                        //string searchString5 = "MaxPool2d";
                        //string searchString6 = "Softmax";

                        //string success = "Yes";
                        string error = "Nope";
                        bool foundText = false;

                        do
                        {
                            currentLine = rd.ReadLine();
                            if (currentLine != null)
                            {
                                foundText = currentLine.Contains(searchString);
                                foundText = currentLine.Contains(searchString1);
                                /*foundText = currentLine.Contains(searchString2);
                                foundText = currentLine.Contains(searchString3);
                                foundText = currentLine.Contains(searchString4);
                                foundText = currentLine.Contains(searchString5);
                                foundText = currentLine.Contains(searchString6);*/
                            }
                        }
                        while (currentLine != null && !foundText);

                        if (foundText)
                        {
                            draw draw = new draw();
                            draw.drawing(panel1);
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }

                    }
                }
            }
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (x <= 130 & x >= 60 )
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
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
