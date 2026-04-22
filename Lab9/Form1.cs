using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private double a = 100;
        private double b = 1;

        public Form1()
        {
            InitializeComponent();
            typeof(PictureBox).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, pictBox1, new object[] { true });
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Введіть коректне число для 'a'");
                return;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Введіть коректне число для 'b'");
                return;
            }

            pictBox1.Invalidate();
        }

        private void pbGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int w = pictBox1.Width;
            int h = pictBox1.Height;
            int centerX = w / 2;
            int centerY = h / 2;

            // Малювання осей
            using (Pen axisPen = new Pen(Color.Black, 1.5f))
            {
                axisPen.CustomEndCap = new AdjustableArrowCap(5, 5);

                g.DrawLine(axisPen, 0, centerY, w, centerY);
                g.DrawLine(axisPen, centerX, h, centerX, 0);
            }

            Font labelFont = new Font("Arial", 8);
            Font axisTitleFont = new Font("Arial", 10, FontStyle.Bold);
            Brush textBrush = Brushes.Black;

            g.DrawString("X", axisTitleFont, textBrush, w - 10, centerY + 5);
            g.DrawString("Y", axisTitleFont, textBrush, centerX - 15, 2);

            int step = 50;
            for (int i = -(w / 2 / step) * step; i <= w / 2; i += step)
            {
                if (i == 0) continue;

                g.DrawLine(Pens.Black, centerX + i, centerY - 3, centerX + i, centerY + 3);
                g.DrawString(i.ToString(), labelFont, textBrush, centerX + i - 10, centerY + 5);

                g.DrawLine(Pens.Black, centerX - 3, centerY - i, centerX + 3, centerY - i);
                g.DrawString(i.ToString(), labelFont, textBrush, centerX + 5, centerY - i - 7);
            }

            // Побудова графіка
            List<PointF> points = new List<PointF>();

            for (double t = 0; t <= 2 * Math.PI; t += 0.01)
            {
                double xVal = a * Math.Cos(t) * (Math.Cos(t) + b);
                double yVal = a * Math.Sin(t) * (Math.Sin(t) + b);

                float screenX = (float)(centerX + xVal);
                float screenY = (float)(centerY - yVal);

                if (Math.Abs(xVal) < w && Math.Abs(yVal) < h)
                {
                    points.Add(new PointF(screenX, screenY));
                }
            }

            if (points.Count > 1)
            {
                using (Pen graphPen = new Pen(Color.Red, 2f))
                {
                    g.DrawLines(graphPen, points.ToArray());
                }
            }
        }
    }
}