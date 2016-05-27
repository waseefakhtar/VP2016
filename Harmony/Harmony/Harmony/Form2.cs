using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace Harmony
{
    public partial class Form2 : Form
    {
        private Form1 firstForm = null;
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Color Swatch";
           

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

        public Color pictureBox1Color
        {
            get { return pictureBox1.BackColor; }
            set { pictureBox1.BackColor = value; }
        }

        public Color pictureBox2Color
        {
            get { return pictureBox2.BackColor; }
            set { pictureBox2.BackColor = value; }
        }

        public Color pictureBox4Color
        {
            get { return pictureBox4.BackColor; }
            set { pictureBox4.BackColor = value; }
        }

        public Color pictureBox5Color
        {
            get { return pictureBox5.BackColor; }
            set { pictureBox5.BackColor = value; }
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
            try
            {
                //PictureBox 1
                int rPictureBox1, gPictureBox1, bPictureBox1;
                float pictureBox1Hue = pictureBox1Color.GetHue();
                float pictureBox1Saturation = pictureBox1Color.GetSaturation();
                float pictureBox1Value = pictureBox1Color.GetBrightness();

                float hPictureBox1 = addHue(pictureBox1Hue, 0);
                float sPictureBox1 = addValueOverflowCap(pictureBox1Saturation, 0);
                float vPictureBox1 = addValueOverflowFlip(pictureBox1Value, 30);

                HsvToRgb(hPictureBox1, sPictureBox1, vPictureBox1, out rPictureBox1, out gPictureBox1, out bPictureBox1);
                Color color1 = Color.FromArgb(rPictureBox1, gPictureBox1, bPictureBox1);
                pictureBox1.BackColor = color1;
                UpdateColor(color1, label7, label8, label9);

                //PictureBox 2
                int rPictureBox2, gPictureBox2, bPictureBox2 ;
                float pictureBox2Hue = pictureBox2Color.GetHue();
                float pictureBox2Saturation = pictureBox2Color.GetSaturation();
                float pictureBox2Value = pictureBox2Color.GetBrightness();

                float hPictureBox2 = addHue(pictureBox2Hue, 0);
                float sPictureBox2 = addValueOverflowFlip(pictureBox2Saturation, -30);
                float vPictureBox2 = addValueOverflowSlow(pictureBox2Value, 10, brake: 50);

                HsvToRgb(hPictureBox2, sPictureBox2, vPictureBox2, out rPictureBox2, out gPictureBox2, out bPictureBox2);
                Color color2 = Color.FromArgb(rPictureBox2, gPictureBox2, bPictureBox2);
                pictureBox2.BackColor = color2;
                UpdateColor(color2, label4, label5, label6);
            
                //PictureBox 4
                int rPictureBox4, gPictureBox4, bPictureBox4;
                float pictureBox4Hue = pictureBox4Color.GetHue();
                float pictureBox4Saturation = pictureBox4Color.GetSaturation();
                float pictureBox4Value = pictureBox4Color.GetBrightness();

                float hPictureBox4 = addHue(pictureBox4Color.GetHue(), 0);
                float sPictureBox4 = addValueOverflowFlip(pictureBoxColor.GetSaturation(), -30);
                float vPictureBox4 = addValueOverflowFlip(pictureBoxColor.GetBrightness(), 30);
                

                HsvToRgb(hPictureBox4, sPictureBox4, vPictureBox4, out rPictureBox4, out gPictureBox4, out bPictureBox4);
                Color color4 = Color.FromArgb(rPictureBox4, gPictureBox4, bPictureBox4);
                pictureBox4.BackColor = color4;
                UpdateColor(color4, label10, label11, label12);

                //PictureBox 5
                int rPictureBox5, gPictureBox5, bPictureBox5;
                float pictureBox5Hue = pictureBox5Color.GetHue();
                float pictureBox5Saturation = pictureBox5Color.GetSaturation();
                float pictureBox5Value = pictureBox5Color.GetBrightness();

                float hPictureBox5 = addHue(pictureBox5Hue, 0);
                float sPictureBox5 = addValueOverflowCap(pictureBox5Saturation, 0);
                float vPictureBox5 = addValueOverflowOppose(pictureBox5Value, 60, roffs: 20);

                HsvToRgb(hPictureBox5, sPictureBox5, vPictureBox5, out rPictureBox5, out gPictureBox5, out bPictureBox5);
                Color color5 = Color.FromArgb(rPictureBox5, gPictureBox5, bPictureBox5);
                //Color color5 = HSBToRGBConversion(hPictureBox5, sPictureBox5, vPictureBox5);

                pictureBox5.BackColor = color5;
                UpdateColor(color5, label13, label14, label15);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message + " Please pick your color again.");
            }
        }

        public static Color HSBToRGBConversion(float hue, float saturation, float brightness)
        {
            float red, green, blue;
            if (saturation == 0)
            {
                red = green = blue = brightness; // achromatic
            }
            else
            {
                var q = brightness < 0.5 ? brightness * (1 + saturation) : brightness + saturation - brightness * saturation;
                var p = 2 * brightness - q;
                red = hue2rgb(p, q, hue + 1f / 3);
                green = hue2rgb(p, q, hue);
                blue = hue2rgb(p, q, hue - 1f / 3);
            }
            return Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
        }
        public static float hue2rgb(float p, float q, float t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1f / 6) return p + (q - p) * 6 * t;
            if (t < 1f / 2) return q;
            if (t < 2f / 3) return p + (q - p) * (2f / 3 - t) * 6;
            return p;
        }


private float addValueOverflowBounce(float v, float add, float cap = 100, float lcap = 0, float min = -1, float max = -1)
        {
            float w = v + add;

            if (min > -1 && w < min) { w = min; }
            if (max > -1 && w > max) { w = max; }

            //If we overflow, need to subtract overflow amount
            if (w > cap)
                return cap - (w - cap);
            else if (w < cap)
                return lcap + (lcap - w);
            return w;
        }

        private float addValueOverflowCap(float v, float add, float cap = 100, float min = -1, float max = -1)
        {
            float w = v + add;

            if (min > -1 && w < min) { w = min; }
            if (max > -1 && w > max) { w = max; }
            
            if (w > cap)
                return cap;
            else if (w < 0)
                return 0;
            return w;
        }

        private float addValueOverflowFlip(float v, float add, float cap = 100, float lcap = 0, float min = -1, float max = -1)
        {
            float w = v + add;

            if (min > -1 && w < min) { w = min; }
            if (max > -1 && w > max) { w = max; }

            //If we overflow, need to subtract instead
            if (w > cap || w < cap)
                return v - add;
            return w;
        }

        private float addValueOverflowSlow(float v, float add, float cap = 100, float lcap = 0, float min = -1, float max = -1, float brake = -1)
        {
            float w = v + add;

            if (min > -1 && w < min) { w = min; }
            if (max > -1 && w > max) { w = max; }

            float b = brake > -1 ? brake : Math.Abs(add);

            //Stop us from overflowing by slowing add down (by 50%) as we approach cap.
            if (w > cap - b)
                return v - add;
            return w;
        }

        private float addValueOverflowOppose(float v, float add, float cap = 100, float roffs = 0)
        {
            float w = v + add;
            if (w > cap) { w = (roffs + w) % cap; }
            return w;
        }

        private float addHue(float h, float add)
        {
            return (360 + h + add) % 360;
        }

        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
                { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        private async void ResetCopyLabel(Label label)
        {
            // wait 2 seconds before setting it back
            await Task.Delay(2000);
            label.Text = "copy";
        }

        private void copyPicture1HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label7.Text);
            copyPicture1HEX.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture1RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label8.Text);
            copyPicture1RGB.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture1HSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label9.Text);
            copyPicture1HSL.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture2HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            copyPicture2HEX.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture2RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text);
            copyPicture2RGB.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture2HSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label6.Text);
            copyPicture2HSL.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture3HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label3.Text);
            copyPicture3HEX.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture3RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
            copyPicture3RGB.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture3HSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            copyPicture3HSL.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture4HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label10.Text);
            copyPicture4HEX.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture4RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label11.Text);
            copyPicture4RGB.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture4HSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label12.Text);
            copyPicture4HSL.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture5HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label13.Text);
            copyPicture5HEX.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture5RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label14.Text);
            copyPicture5RGB.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void copyPicture5HSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label15.Text);
            copyPicture5HSL.Text = "copied!";

            ResetCopyLabel((Label)sender);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveScreenshot = new SaveFileDialog();
            saveScreenshot.Filter = ".jpg|*.jpg|.bmp|*.bmp|.gif|*.gif|.ase|*.ase|.pdf|*.pdf";
            saveScreenshot.Title = "Save an Image File";

            // If the user has choosed a path where to save the screenshot
            if (saveScreenshot.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                bmpScreenshot.Save(saveScreenshot.FileName, ImageFormat.Png);
                this.Show();
            }
        }
    }
}
