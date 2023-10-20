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
        private Color pointColor = Color.Red;
        private Color lineColor = Color.Red;

        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (points.Count >= 2)
            {
                Graphics graphics = panel1.CreateGraphics();
                Pen linePen = new Pen(lineColor, 2f);

                for (int i = 1; i < points.Count; i++)
                {
                    graphics.DrawLine(linePen, points[i - 1], points[i]);
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point clickPoint = panel1.PointToClient(Cursor.Position); 
            
            using (Graphics graphics = panel1.CreateGraphics())
            {
                Pen pointPen = new Pen(pointColor, 5);

                graphics.FillEllipse(new SolidBrush(pointColor), clickPoint.X - 1, clickPoint.Y - 1, 8, 8);

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

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            points.Clear();
            panel1.Invalidate();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pointColor = Color.Red; 
            lineColor = Color.Red;  
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pointColor = Color.Blue; 
            lineColor = Color.Blue;  
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pointColor = Color.Green;
            lineColor = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pointColor = Color.Orange;
            lineColor = Color.Orange;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pointColor = Color.Violet;
            lineColor = Color.Violet;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            pointColor = Color.Black;
            lineColor = Color.Black;
        }
    }
}
