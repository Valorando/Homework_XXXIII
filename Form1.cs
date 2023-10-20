using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using Jace;

namespace Homework_19_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap graphBitmap = new Bitmap(panel1.Width, panel1.Height);

            using (Graphics g = Graphics.FromImage(graphBitmap))
            {
                g.Clear(panel1.BackColor);

                g.DrawLine(Pens.Blue, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
                g.DrawLine(Pens.Blue, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);

                panel1.BackgroundImage = graphBitmap;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            float k = (float)height / width;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i;
                int y = (int)(k * x);

                points[i] = new Point(x, y);
            }

            graphics.DrawLines(pen, points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i - width / 2; 
                int y = -(int)(0.1 * Math.Pow(x, 2)) + height / 2; 

                points[i] = new Point(i, y);
            }

            graphics.DrawLines(pen, points);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i - width / 2; 
                int y = -(int)Math.Pow(x / 2, 3) + height / 2; 

                points[i] = new Point(i, y);
            }

            graphics.DrawLines(pen, points);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 1; i < width; i++)
            {
                int x = i;
                double y = Math.Log(x);

                int yCoord = (int)(height - y * 50); 

                points[i] = new Point(i, yCoord);
            }

            graphics.DrawLines(pen, points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));


            }
            graphics.DrawLines(pen, points);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Cos((double)i / 10) * 100 + 200));


            }
            graphics.DrawLines(pen, points);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Tan((double)i / 10) * 100 + 200));


            }
            graphics.DrawLines(pen, points);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i;
                double y = Math.Asin((double)(x - width / 2) / (width / 2)) * 50 + height / 2;

                points[i] = new Point(i, (int)y);
            }
            graphics.DrawLines(pen, points);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i;
                double y = Math.Acos((double)(x - width / 2) / (width / 2)) * 50 + height / 2;

                points[i] = new Point(i, (int)y);
            }
            graphics.DrawLines(pen, points);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = panel1.Width;
            int height = panel1.Height;

            Point[] points = new Point[width];

            for (int i = 0; i < width; i++)
            {
                int x = i;
                double y = Math.Atan((double)(x - width / 2) / (width / 2)) * 50 + height / 2;

                points[i] = new Point(i, (int)y);
            }

            graphics.DrawLines(pen, points);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap graphBitmap = new Bitmap(panel1.Width, panel1.Height);

            using (Graphics g = Graphics.FromImage(graphBitmap))
            {
                g.Clear(panel1.BackColor);

                g.DrawLine(Pens.Blue, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
                g.DrawLine(Pens.Blue, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);

                panel1.BackgroundImage = graphBitmap;
            }
        }
    }
}
