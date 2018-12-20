using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Painting.DrawAxis(pictureBox1.Width, pictureBox1.Height);
            Line Lines = new Line();
            Lines.Lines = new List<PointF>()
            {
                new PointF(100, 200),
                new PointF(200, -100),
                new PointF(-100, 400),
                new PointF(400, 600),
                new PointF(600, 300),
            };
            pictureBox1.Image = Painting.DrawLine((Bitmap)pictureBox1.Image, Lines);
        }
    }
}
