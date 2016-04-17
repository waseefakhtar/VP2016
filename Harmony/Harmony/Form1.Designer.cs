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
            this.cmykLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.PictureBox();
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
            this.appTitle.Size = new System.Drawing.Size(930, 23);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "HARMONY";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorWheel
            // 
            this.colorWheel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorWheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorWheel.Image = ((System.Drawing.Image)(resources.GetObject("colorWheel.Image")));
            this.colorWheel.Location = new System.Drawing.Point(234, 68);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(463, 463);
            this.colorWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.colorWheel.TabIndex = 1;
            this.colorWheel.TabStop = false;
            this.colorWheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorWheel_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(564, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "CMYK";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(564, 296);
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
            this.label3.Location = new System.Drawing.Point(564, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "HEX";
            // 
            // cmykLabel
            // 
            this.cmykLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmykLabel.AutoSize = true;
            this.cmykLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmykLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmykLabel.Location = new System.Drawing.Point(622, 317);
            this.cmykLabel.Name = "cmykLabel";
            this.cmykLabel.Size = new System.Drawing.Size(0, 21);
            this.cmykLabel.TabIndex = 5;
            // 
            // rLabel
            // 
            this.rLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rLabel.AutoSize = true;
            this.rLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rLabel.Location = new System.Drawing.Point(622, 296);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(20, 21);
            this.rLabel.TabIndex = 6;
            this.rLabel.Text = "R";
            // 
            // hexLabel
            // 
            this.hexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hexLabel.Location = new System.Drawing.Point(622, 275);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(0, 21);
            this.hexLabel.TabIndex = 7;
            // 
            // gLabel
            // 
            this.gLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gLabel.AutoSize = true;
            this.gLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gLabel.Location = new System.Drawing.Point(658, 296);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(21, 21);
            this.gLabel.TabIndex = 8;
            this.gLabel.Text = "G";
            // 
            // bLabel
            // 
            this.bLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bLabel.Location = new System.Drawing.Point(695, 296);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(19, 21);
            this.bLabel.TabIndex = 9;
            this.bLabel.Text = "B";
            // 
            // selector
            // 
            this.selector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selector.Location = new System.Drawing.Point(597, 211);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(100, 50);
            this.selector.TabIndex = 10;
            this.selector.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(930, 490);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.cmykLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorWheel);
            this.Controls.Add(this.appTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label cmykLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.PictureBox selector;
    }
}

