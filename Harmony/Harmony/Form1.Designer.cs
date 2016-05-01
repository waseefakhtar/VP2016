namespace Harmony
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appTitle = new System.Windows.Forms.Label();
            this.colorWheel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.PictureBox();
            this.Harmonize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.appTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.appTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.appTitle.Location = new System.Drawing.Point(0, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.appTitle.Size = new System.Drawing.Size(1184, 23);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "HARMONY";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorWheel
            // 
            this.colorWheel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorWheel.BackColor = System.Drawing.Color.Transparent;
            this.colorWheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorWheel.Image = ((System.Drawing.Image)(resources.GetObject("colorWheel.Image")));
            this.colorWheel.Location = new System.Drawing.Point(361, 68);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(463, 463);
            this.colorWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.colorWheel.TabIndex = 1;
            this.colorWheel.TabStop = false;
            this.colorWheel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorWheel_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(974, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "HSL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(974, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "RGB";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(974, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "HEX";
            // 
            // selector
            // 
            this.selector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selector.Location = new System.Drawing.Point(974, 240);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(100, 50);
            this.selector.TabIndex = 10;
            this.selector.TabStop = false;
            // 
            // Harmonize
            // 
            this.Harmonize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Harmonize.Location = new System.Drawing.Point(557, 565);
            this.Harmonize.Name = "Harmonize";
            this.Harmonize.Size = new System.Drawing.Size(75, 23);
            this.Harmonize.TabIndex = 11;
            this.Harmonize.Text = "Harmonize";
            this.Harmonize.UseVisualStyleBackColor = true;
            this.Harmonize.Click += new System.EventHandler(this.Harmonize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Harmonize);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorWheel);
            this.Controls.Add(this.appTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox colorWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox selector;
        private System.Windows.Forms.Button Harmonize;
    }
}

