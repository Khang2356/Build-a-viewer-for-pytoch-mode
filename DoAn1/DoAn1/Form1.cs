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
using System.Text.RegularExpressions;

namespace DoAn1
{
    public partial class Form1 : Form
    {
        //Khai báo thư viện vẽ
        Graphics grs;
        public object panel;

        public Form1()
        {
            InitializeComponent();
            grs = panel1.CreateGraphics();
  

        }
        //Nút thực hiện chức năng mở file .txt, đọc file và vẽ
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(op.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            System.IO.StreamReader sr1 = new System.IO.StreamReader(op.FileName);
            string input = sr1.ReadToEnd();
            string[] character = new string[] { "def forward", "Conv2d", "AvgPool2d", "BatchNorm2d", "Dropout", "Linear", "MaxPool2d", "Softmax" };
            string pattern = @"^.*\b(" + string.Join("|", character) + @")\b.*$";

            MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.Multiline);
            foreach (Match match in matches)
            {
                SinglyLinkedList sll = new SinglyLinkedList();
                sll.AddFirst("def forward");
                sll.addLast("Conv2d");
                sll.addLast("AvgPool2d");
                sll.addLast("BatchNorm2d");
                sll.addLast("Dropout");
                sll.addLast("Linear");
                sll.addLast("Maxpool2d");
                sll.addLast("Softmax");

                draw dr = new draw();
                dr.drawing(panel1);
                dr.drawing1(panel1);
                dr.drawing2(panel1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
        //Hàm hiện thông tin của layer
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (x <= 160 & x >= 90)
            {
                if (y >= 40 & y <= 70)
                {
                    label1.Text = "";
                }
                if (y >= 100 & y <= 130)
                {
                    label1.Text = "Conv2d(3, 64, kernel_size=11, stride=4, padding=2)";

                }
                if (y >= 160 & y <= 190)
                {
                    label1.Text = "AvgPool2d(3, 64, kernel_size=9, stride=3, padding=4, divisor_override=20)";
                }
            }
            else
                label1.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
