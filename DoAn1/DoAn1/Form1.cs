using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserControl1 u2 = new UserControl1();
            
        }
       
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void userControl11_Load(object sender, EventArgs e)
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

        private void userControl11_Load_1(object sender, EventArgs e)
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
        {


            Pen p = new Pen(Color.Red, 1);
            Graphics g = this.CreateGraphics();
            g.DrawLine(p, new Point(500, 200), new Point(500, 20));
            p.Dispose();
            g.Dispose();
        }
    }
}
