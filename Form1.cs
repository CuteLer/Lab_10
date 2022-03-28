using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color gray = Color.FromArgb(153, 153, 153);
            Color pink = Color.FromArgb(248, 188, 188);

            SolidBrush col_1 = new SolidBrush(gray);
            SolidBrush col_2 = new SolidBrush(pink);

            //Координаты треугольника головы
            Point[] p_1 = new Point[3];
            p_1[0] = new Point(160, 220);
            p_1[1] = new Point(406, 403);
            p_1[2] = new Point(368, 125);
            //Треугольник головы
            g.FillPolygon(col_1, p_1);
             //Круги левого уха
            g.FillEllipse(col_1, new Rectangle(100, 150, 126, 126));
            g.FillEllipse(col_2, new Rectangle(142, 182, 70, 70));
            //Круги правого уха
            g.FillEllipse(col_1, new Rectangle(368 - 60, 125 - 70, 126, 126));
            g.FillEllipse(col_2, new Rectangle(333, 182 - 90, 70, 70));

            //Координаты треугольника тела
            Point[] p_2 = new Point[3];
            p_2[0] = new Point(100, 522);
            p_2[1] = new Point(270, 230);
            p_2[2] = new Point(320, 230 + 252 + 80);
            //Треугольник тела
            g.FillPolygon(col_1, p_2);
            //Хвост
            g.DrawBezier(new Pen(Color.Black, 3), new Point(200, 500), new Point(90, 700), new Point(100, 275), new Point(15, 450));
            //Нос
            g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(395, 393, 20, 20));
            //Усы
            g.DrawLine(new Pen(Color.Black, 3), new Point(355, 395), new Point(450, 410));
            g.DrawLine(new Pen(Color.Black, 3), new Point(365, 425), new Point(450, 380));
            //Глаза
            g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(335, 240, 15, 15));
            g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(300, 260, 15, 15));
        }

    }
}
