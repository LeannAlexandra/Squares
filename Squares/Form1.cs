using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Create Bitmap object
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            // Create and initialize Graphics
            Graphics graphics = Graphics.FromImage(bitmap);
            // Create Pen
            Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
            // Draw arc
            graphics.DrawArc(pen, 0, 0, 700, 700, 0, 180);
            // Create another Pen
            Pen pen1 = new Pen(Color.FromKnownColor(KnownColor.Red), 2);
            // Draw ellipse
            graphics.DrawEllipse(pen1, 10, 10, 900, 700);
            // Save the drawing into desired image format
            bitmap.Save(@"drawing.png");
        }
    }
}
