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
    public partial class Form2 : Form
    {
        private Form1 firstForm = null;

        public Form2()
        {
            InitializeComponent();

            pictureBox3.BackColor = pictureBoxColor;

          

            

        }
        

        public void UpdateColor(Color color, Label hexLabel, Label rgbLabel, Label hslLabel)
        {
            // update the RGB hex value
            hexLabel.Text = string.Format("#{0:x2}{1:x2}{2:x2}", color.R, color.G, color.B);
            rgbLabel.Text = string.Format("rgb({0:N0}, {1:N0}, {2:N0})", color.R, color.G, color.B);
            hslLabel.Text = string.Format("hsl({0:N0}, {1:N0}%, {2:N0}%)", color.GetHue(), color.GetSaturation() * 100, color.GetBrightness() * 100);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public Color pictureBoxColor
        {
            get { return pictureBox3.BackColor; }
            set { pictureBox3.BackColor = value; }
        }

        public String hexText
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        public String rgbText
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public String hslText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Color color1 = Color.FromArgb(pictureBoxColor.R - 30, pictureBoxColor.G - 30, pictureBoxColor.B - 30);
            pictureBox1.BackColor = color1;
            UpdateColor(color1, label7, label8, label9);

            Color color2 = Color.FromArgb(pictureBoxColor.R - 60, pictureBoxColor.G - 60, pictureBoxColor.B - 60);
            pictureBox2.BackColor = color2;
            UpdateColor(color1, label4, label5, label6);

            Color color4 = Color.FromArgb(pictureBoxColor.R / 2, pictureBoxColor.G / 2, pictureBoxColor.B / 2);
            pictureBox4.BackColor = color4;
            UpdateColor(color4, label10, label11, label12);

            Color color5 = Color.FromArgb(pictureBoxColor.R / 3, pictureBoxColor.G / 3, pictureBoxColor.B / 3);
            pictureBox5.BackColor = color5;
            UpdateColor(color5, label13, label14, label15);
        }
    }
}
