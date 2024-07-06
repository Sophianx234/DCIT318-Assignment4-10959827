using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class DrawingForm1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;

        public DrawingForm1()
        {
            InitializeComponent();
        }

        private void DrawingForm1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void DrawingForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && lastPoint != Point.Empty)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        private void DrawingForm1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
            }
        }
    }
}
