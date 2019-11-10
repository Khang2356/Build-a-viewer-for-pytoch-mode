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
using System.Drawing.Drawing2D;

namespace DoAn1
{
    //Class vẽ
    public class draw 
    {
        //Khai báo các thư viện và biến tọa độ
        Graphics grs;
        int x = 90, y = 40;
        int d = 70, r = 30;

        Font font = new Font("TimeNewRoman", 10f);
        Pen pen = new Pen(Color.Black, 2f);
        Pen penarrow = new Pen(Color.Black, 4F) { EndCap = LineCap.ArrowAnchor };
        SolidBrush sbr = new SolidBrush(Color.Green);
        SolidBrush sbr2 = new SolidBrush(Color.DarkSlateBlue);
        SolidBrush sbr3 = new SolidBrush(Color.White);

        //Hàm vẽ layer đầu tiên
        public void drawing(Control control)

        {   
            grs = control.CreateGraphics();
            var rec = new Rectangle(x, y, d, r);
            grs.FillRectangle(sbr, x, y, d, r);
            string text = @"data";
            grs.DrawString(text, font, sbr3, x + 15, y + 7);
        }
 //Các hàm vẽ layer tiếp theo 
        public void drawing1(Control control)
        {
            grs = control.CreateGraphics();
            grs.DrawLine(penarrow, (x + x + d) / 2, (y + r), (x + x + d) / 2, (y + r + r));
            y = y + r + r;
            grs.FillRectangle(sbr2, x, y, d, r);
            string text2 = @"conv1";
            grs.DrawString(text2, font, sbr3, x + 15, y + 7);
        }

        public void drawing2(Control control)
        {
           
            grs = control.CreateGraphics();
            grs.DrawLine(penarrow, (x + x + d) / 2, (y + r), (x + x + d) / 2, (y + r + r));
            y = y + r + r;
            grs.FillRectangle(sbr2, x, y, d, r);
            string text3 = @"conv2";
            grs.DrawString(text3, font, sbr3, x + 15, y + 7);
        }

        public void drawing3(Control control)
        {
            grs = control.CreateGraphics();
            grs.DrawLine(penarrow, (x + x + d) / 2, (y + r), (x + x + d) / 2, (y + r + r));
            y = y + r + r;
            grs.FillRectangle(sbr2, x, y, d, r);
            string text2 = @"conv3";
            grs.DrawString(text2, font, sbr3, x + 15, y + 7);
        }

        public void drawing4(Control control)
        {
            grs = control.CreateGraphics();
            grs.DrawLine(penarrow, (x + x + d) / 2, (y + r), (x + x + d) / 2, (y + r + r));
            y = y + r + r;
            grs.FillRectangle(sbr2, x, y, d, r);
            string text2 = @"conv4";
            grs.DrawString(text2, font, sbr3, x + 15, y + 7);
        }


    }
}
