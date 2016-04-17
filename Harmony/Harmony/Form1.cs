using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // PictureBox: This grabs the pixel color and sends that data to the text labels
        private void colorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = (Bitmap)colorWheel.Image;
                Color clr = bmp.GetPixel(e.X, e.Y);
                hexLabel.Text = clr.Name;
                rLabel.Text = clr.R.ToString();
                gLabel.Text = clr.G.ToString();
                bLabel.Text = clr.B.ToString();
                selector.BackColor = clr;
            }
            catch
            {

            }
        }

    }
}
