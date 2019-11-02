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
    public class draw
    {
        Graphics grs;
       
        public void drawing(Control control)

        {
            MaxPool2d map=new MaxPool2d() ;
            
            grs = control.CreateGraphics();
            SolidBrush sbr = new SolidBrush(Color.Green);
            grs.FillRectangle(sbr, 60, 40, 70, 30);
            SolidBrush sbr3 = new SolidBrush(Color.White);
            FontFamily family = new FontFamily("Times New Roman");
            System.Drawing.Font font = new System.Drawing.Font(family, 10.0f);
            string text = @"data";
            grs.DrawString(text, font, sbr3, 80, 50);
        }

        public void drawing1(Control control)
        {
            grs = control.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2f);
            Point p1 = new Point(95, 70);
            Point p2 = new Point(95, 100);
            Point p3 = new Point(90, 90);
            Point p4 = new Point(100, 90);
            grs.DrawLine(pen, p1, p2);
            grs.DrawLine(pen, p3, p2);
            grs.DrawLine(pen, p4, p2);
            SolidBrush sbr2 = new SolidBrush(Color.DarkSlateBlue);
            grs.FillRectangle(sbr2, 60, 100, 70, 30);
            SolidBrush sbr3 = new SolidBrush(Color.White);
            FontFamily family = new FontFamily("Times New Roman");
            System.Drawing.Font font = new System.Drawing.Font(family, 10.0f);
            string text2 = @"conv1";
            grs.DrawString(text2, font, sbr3, 80, 110);
        }

        public void drawing2(Control control)
        {
            grs = control.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2f);
            Point p5 = new Point(95, 130);
            Point p6 = new Point(95, 160);
            Point p7 = new Point(90, 150);
            Point p8 = new Point(100, 150);
            grs.DrawLine(pen, p5, p6);
            grs.DrawLine(pen, p7, p6);
            grs.DrawLine(pen, p8, p6);
            SolidBrush sbr2 = new SolidBrush(Color.DarkSlateBlue);
            grs.FillRectangle(sbr2, 60, 160, 70, 30);
            SolidBrush sbr3 = new SolidBrush(Color.White);
            FontFamily family = new FontFamily("Times New Roman");
            System.Drawing.Font font = new System.Drawing.Font(family, 10.0f);
            string text3 = @"conv2";
            grs.DrawString(text3, font, sbr3, 80, 170);
        }
    }
}
