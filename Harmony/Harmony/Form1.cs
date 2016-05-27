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
        Form2 secondForm = new Form2();

        public Form1()
        {
            InitializeComponent();
     
        }

        private void colorWheel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = (Bitmap)colorWheel.Image;
                Color clr = bmp.GetPixel(e.X, e.Y);
                selector.BackColor = clr;
                UpdateColor(clr);

                secondForm.pictureBoxColor = clr;
                secondForm.hexText = label3.Text;
                secondForm.rgbText = label2.Text;
                secondForm.hslText = label1.Text;

                secondForm.pictureBox1Color = clr;
                secondForm.pictureBox2Color = clr;
                secondForm.pictureBox4Color = clr;
                secondForm.pictureBox5Color = clr;
            }
            catch { }
        }

        private void UpdateColor(Color color)
        {
            // update the RGB hex value
            label3.Text = string.Format("#{0:x2}{1:x2}{2:x2}", color.R, color.G, color.B);
            label2.Text = string.Format("rgb({0:N0}, {1:N0}, {2:N0})", color.R, color.G, color.B);
            label1.Text = string.Format("hsl({0:N0}, {1:N0}%, {2:N0}%)", color.GetHue(), color.GetSaturation() * 100, color.GetBrightness() * 100);
        }

        private void Harmonize_Click(object sender, EventArgs e)
        {
            secondForm.Show();
        }
    }
}
