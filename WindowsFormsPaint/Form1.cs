using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsPaint
{
    public partial class FormMain : Form
    {
        Graphics graphics;
        int dx = 0, dy = 0;
        Pen pen = new Pen(Color.Black);

        public FormMain()
        {
            InitializeComponent();
            graphics = pictureBoxCanvas.CreateGraphics();
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                graphics.DrawLine(pen, dx, dy, e.X, e.Y);
            }
            dx = e.X;
            dy = e.Y;
        }
    }
}
