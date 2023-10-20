using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_19_10_II
{
    public partial class Form1 : Form
    {
        private List<Point> points = new List<Point>();

        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (points.Count >= 2)
            {
                Graphics graphics = panel1.CreateGraphics();
                Pen pen = new Pen(Color.Red, 5);

                for (int i = 1; i < points.Count; i++)
                {
                    graphics.DrawLine(pen, points[i - 1], points[i]);
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point clickPoint = panel1.PointToClient(Cursor.Position); 
            
            using (Graphics graphics = panel1.CreateGraphics())
            {
               
                graphics.FillEllipse(Brushes.Red, clickPoint.X - 1, clickPoint.Y - 1, 8, 8);

                points.Add(clickPoint); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            
            int cellWidth = 30; 
            int cellHeight = 30; 
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;
            Pen gridPen = new Pen(Color.Blue, 1);

            for (int x = 0; x < panel1.Width; x += cellWidth)
            {
                graphics.DrawLine(gridPen, x, 0, x, panel1.Height);
            }

            for (int y = 0; y < panel1.Height; y += cellHeight)
            {
                graphics.DrawLine(gridPen, 0, y, panel1.Width, y);
            }

            Pen axisPen = new Pen(Color.Black, 2f);
            Pen arrowPen = new Pen(Color.Black, 2f);
            SolidBrush arrowBrush = new SolidBrush(Color.Black);

            
            int axisY = panelHeight - (panelHeight % cellHeight); 
            graphics.DrawLine(axisPen, cellWidth, axisY, panelWidth, axisY);
            graphics.FillPolygon(arrowBrush, new Point[] { new Point(panelWidth - 10, axisY - 5), new Point(panelWidth - 10, axisY + 5), new Point(panelWidth, axisY) });

            graphics.DrawLine(axisPen, cellWidth, panel1.Height, cellWidth, 0);
            graphics.FillPolygon(arrowBrush, new Point[] { new Point(cellWidth - 5, 10), new Point(cellWidth + 5, 10), new Point(cellWidth, 0) });
        }
    }
}
