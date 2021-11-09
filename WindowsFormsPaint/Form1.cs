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

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pen.Color = colorDialog.Color;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBarPenWidth.Value;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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