namespace OtsuMethod
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OriginalImage64 = new System.Windows.Forms.Button();
            this.GrayImage64 = new System.Windows.Forms.Button();
            this.OriginalImage32 = new System.Windows.Forms.Button();
            this.GrayImage32 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FourClassesThreshold32 = new System.Windows.Forms.Button();
            this.ThreeClassesThreshold32 = new System.Windows.Forms.Button();
            this.TwoClassesThreshold32 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FourClassesThreshold64 = new System.Windows.Forms.Button();
            this.ThreeClassesThreshold64 = new System.Windows.Forms.Button();
            this.TwoClassesThreshold64 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FourClassesThreshold256 = new System.Windows.Forms.Button();
            this.ThreeCLassesThreshold256 = new System.Windows.Forms.Button();
            this.TwoClassesThreshold256 = new System.Windows.Forms.Button();
            this.GrayImage256 = new System.Windows.Forms.Button();
            this.OriginalImage256 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Image_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Image_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.drawHistogram1 = new OtsuMethod.DrawHistogram();
            this.risuvaneNaHistograma1 = new OtsuMethod.DrawHistogram();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OriginalImage64
            // 
            this.OriginalImage64.Location = new System.Drawing.Point(22, 19);
            this.OriginalImage64.Name = "OriginalImage64";
            this.OriginalImage64.Size = new System.Drawing.Size(160, 25);
            this.OriginalImage64.TabIndex = 1;
            this.OriginalImage64.Text = "Original Image";
            this.OriginalImage64.UseVisualStyleBackColor = true;
            this.OriginalImage64.Click += new System.EventHandler(this.OriginalImage64_Click);
            // 
            // GrayImage64
            // 
            this.GrayImage64.Location = new System.Drawing.Point(22, 91);
            this.GrayImage64.Name = "GrayImage64";
            this.GrayImage64.Size = new System.Drawing.Size(160, 25);
            this.GrayImage64.TabIndex = 2;
            this.GrayImage64.Text = "Gray Image";
            this.GrayImage64.UseVisualStyleBackColor = true;
            this.GrayImage64.Click += new System.EventHandler(this.GrayImage64_Click);
            // 
            // OriginalImage32
            // 
            this.OriginalImage32.Location = new System.Drawing.Point(22, 19);
            this.OriginalImage32.Name = "OriginalImage32";
            this.OriginalImage32.Size = new System.Drawing.Size(160, 25);
            this.OriginalImage32.TabIndex = 3;
            this.OriginalImage32.Text = "Original Image";
            this.OriginalImage32.UseVisualStyleBackColor = true;
            this.OriginalImage32.Click += new System.EventHandler(this.OriginalImage32_Click);
            // 
            // GrayImage32
            // 
            this.GrayImage32.Location = new System.Drawing.Point(22, 91);
            this.GrayImage32.Name = "GrayImage32";
            this.GrayImage32.Size = new System.Drawing.Size(160, 25);
            this.GrayImage32.TabIndex = 4;
            this.GrayImage32.Text = "Gray Image";
            this.GrayImage32.UseVisualStyleBackColor = true;
            this.GrayImage32.Click += new System.EventHandler(this.GrayImage32_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(560, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FourClassesThreshold32);
            this.groupBox1.Controls.Add(this.ThreeClassesThreshold32);
            this.groupBox1.Controls.Add(this.TwoClassesThreshold32);
            this.groupBox1.Controls.Add(this.GrayImage32);
            this.groupBox1.Controls.Add(this.OriginalImage32);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gray levels : 32";
            // 
            // FourClassesThreshold32
            // 
            this.FourClassesThreshold32.Location = new System.Drawing.Point(204, 91);
            this.FourClassesThreshold32.Name = "FourClassesThreshold32";
            this.FourClassesThreshold32.Size = new System.Drawing.Size(160, 38);
            this.FourClassesThreshold32.TabIndex = 13;
            this.FourClassesThreshold32.Text = "Three thresholds";
            this.FourClassesThreshold32.UseVisualStyleBackColor = true;
            this.FourClassesThreshold32.Click += new System.EventHandler(this.FourClassesThreshold32_Click);
            // 
            // ThreeClassesThreshold32
            // 
            this.ThreeClassesThreshold32.Location = new System.Drawing.Point(204, 50);
            this.ThreeClassesThreshold32.Name = "ThreeClassesThreshold32";
            this.ThreeClassesThreshold32.Size = new System.Drawing.Size(160, 35);
            this.ThreeClassesThreshold32.TabIndex = 12;
            this.ThreeClassesThreshold32.Text = "Two thresholds";
            this.ThreeClassesThreshold32.UseVisualStyleBackColor = true;
            this.ThreeClassesThreshold32.Click += new System.EventHandler(this.ThreeClassesThreshold32_Click);
            // 
            // TwoClassesThreshold32
            // 
            this.TwoClassesThreshold32.Location = new System.Drawing.Point(204, 9);
            this.TwoClassesThreshold32.Name = "TwoClassesThreshold32";
            this.TwoClassesThreshold32.Size = new System.Drawing.Size(160, 35);
            this.TwoClassesThreshold32.TabIndex = 11;
            this.TwoClassesThreshold32.Text = "One threshold";
            this.TwoClassesThreshold32.UseVisualStyleBackColor = true;
            this.TwoClassesThreshold32.Click += new System.EventHandler(this.TwoClassesThreshold32_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FourClassesThreshold64);
            this.groupBox2.Controls.Add(this.ThreeClassesThreshold64);
            this.groupBox2.Controls.Add(this.TwoClassesThreshold64);
            this.groupBox2.Controls.Add(this.OriginalImage64);
            this.groupBox2.Controls.Add(this.GrayImage64);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(418, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 135);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gray levels : 64";
            // 
            // FourClassesThreshold64
            // 
            this.FourClassesThreshold64.Location = new System.Drawing.Point(205, 91);
            this.FourClassesThreshold64.Name = "FourClassesThreshold64";
            this.FourClassesThreshold64.Size = new System.Drawing.Size(160, 38);
            this.FourClassesThreshold64.TabIndex = 20;
            this.FourClassesThreshold64.Text = "Three thresholds";
            this.FourClassesThreshold64.UseVisualStyleBackColor = true;
            this.FourClassesThreshold64.Click += new System.EventHandler(this.FourClassesThreshold64_Click);
            // 
            // ThreeClassesThreshold64
            // 
            this.ThreeClassesThreshold64.Location = new System.Drawing.Point(205, 50);
            this.ThreeClassesThreshold64.Name = "ThreeClassesThreshold64";
            this.ThreeClassesThreshold64.Size = new System.Drawing.Size(160, 36);
            this.ThreeClassesThreshold64.TabIndex = 19;
            this.ThreeClassesThreshold64.Text = "Two thresholds";
            this.ThreeClassesThreshold64.UseVisualStyleBackColor = true;
            this.ThreeClassesThreshold64.Click += new System.EventHandler(this.ThreeClassesThreshold64_Click);
            // 
            // TwoClassesThreshold64
            // 
            this.TwoClassesThreshold64.Location = new System.Drawing.Point(205, 9);
            this.TwoClassesThreshold64.Name = "TwoClassesThreshold64";
            this.TwoClassesThreshold64.Size = new System.Drawing.Size(160, 35);
            this.TwoClassesThreshold64.TabIndex = 18;
            this.TwoClassesThreshold64.Text = "One threshold";
            this.TwoClassesThreshold64.UseVisualStyleBackColor = true;
            this.TwoClassesThreshold64.Click += new System.EventHandler(this.TwoClassesThreshold64_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FourClassesThreshold256);
            this.groupBox3.Controls.Add(this.ThreeCLassesThreshold256);
            this.groupBox3.Controls.Add(this.TwoClassesThreshold256);
            this.groupBox3.Controls.Add(this.GrayImage256);
            this.groupBox3.Controls.Add(this.OriginalImage256);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(814, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 135);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gray levels : 256";
            // 
            // FourClassesThreshold256
            // 
            this.FourClassesThreshold256.Location = new System.Drawing.Point(204, 91);
            this.FourClassesThreshold256.Name = "FourClassesThreshold256";
            this.FourClassesThreshold256.Size = new System.Drawing.Size(160, 36);
            this.FourClassesThreshold256.TabIndex = 22;
            this.FourClassesThreshold256.Text = "Three thresholds";
            this.FourClassesThreshold256.UseVisualStyleBackColor = true;
            this.FourClassesThreshold256.Click += new System.EventHandler(this.FourClassesThreshold256_Click);
            // 
            // ThreeCLassesThreshold256
            // 
            this.ThreeCLassesThreshold256.Location = new System.Drawing.Point(204, 50);
            this.ThreeCLassesThreshold256.Name = "ThreeCLassesThreshold256";
            this.ThreeCLassesThreshold256.Size = new System.Drawing.Size(160, 36);
            this.ThreeCLassesThreshold256.TabIndex = 21;
            this.ThreeCLassesThreshold256.Text = "Two thresholds";
            this.ThreeCLassesThreshold256.UseVisualStyleBackColor = true;
            this.ThreeCLassesThreshold256.Click += new System.EventHandler(this.ThreeCLassesThreshold256_Click);
            // 
            // TwoClassesThreshold256
            // 
            this.TwoClassesThreshold256.Location = new System.Drawing.Point(204, 9);
            this.TwoClassesThreshold256.Name = "TwoClassesThreshold256";
            this.TwoClassesThreshold256.Size = new System.Drawing.Size(160, 35);
            this.TwoClassesThreshold256.TabIndex = 20;
            this.TwoClassesThreshold256.Text = "One threshold";
            this.TwoClassesThreshold256.UseVisualStyleBackColor = true;
            this.TwoClassesThreshold256.Click += new System.EventHandler(this.TwoClassesThreshold256_Click);
            // 
            // GrayImage256
            // 
            this.GrayImage256.Location = new System.Drawing.Point(22, 91);
            this.GrayImage256.Name = "GrayImage256";
            this.GrayImage256.Size = new System.Drawing.Size(160, 25);
            this.GrayImage256.TabIndex = 19;
            this.GrayImage256.Text = "Gray Image";
            this.GrayImage256.UseVisualStyleBackColor = true;
            this.GrayImage256.Click += new System.EventHandler(this.GrayImage256_Click);
            // 
            // OriginalImage256
            // 
            this.OriginalImage256.Location = new System.Drawing.Point(22, 19);
            this.OriginalImage256.Name = "OriginalImage256";
            this.OriginalImage256.Size = new System.Drawing.Size(160, 25);
            this.OriginalImage256.TabIndex = 18;
            this.OriginalImage256.Text = "Original Image";
            this.OriginalImage256.UseVisualStyleBackColor = true;
            this.OriginalImage256.Click += new System.EventHandler(this.OriginalImage256_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_Image_ToolStripMenuItem,
            this.Save_Image_ToolStripMenuItem,
            this.Exit_StripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // Open_Image_ToolStripMenuItem
            // 
            this.Open_Image_ToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Open_Image_ToolStripMenuItem.Name = "Open_Image_ToolStripMenuItem";
            this.Open_Image_ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.Open_Image_ToolStripMenuItem.Text = "Open Image";
            this.Open_Image_ToolStripMenuItem.Click += new System.EventHandler(this.Open_Image_ToolStripMenuItem_Click);
            // 
            // Save_Image_ToolStripMenuItem
            // 
            this.Save_Image_ToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Save_Image_ToolStripMenuItem.Name = "Save_Image_ToolStripMenuItem";
            this.Save_Image_ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.Save_Image_ToolStripMenuItem.Text = "Save Image";
            this.Save_Image_ToolStripMenuItem.Click += new System.EventHandler(this.Save_Image_ToolStripMenuItem_Click);
            // 
            // Exit_StripMenuItem
            // 
            this.Exit_StripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Exit_StripMenuItem.Name = "Exit_StripMenuItem";
            this.Exit_StripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.Exit_StripMenuItem.Text = "Exit";
            this.Exit_StripMenuItem.Click += new System.EventHandler(this.Exit_StripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(552, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Threshold values";
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(560, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(560, 379);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 23;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "threshold 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "threshold 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "threshold 3";
            // 
            // drawHistogram1
            // 
            this.drawHistogram1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawHistogram1.DisplayColor = System.Drawing.Color.Black;
            this.drawHistogram1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawHistogram1.Location = new System.Drawing.Point(698, 175);
            this.drawHistogram1.Name = "drawHistogram1";
            this.drawHistogram1.Offset = 20;
            this.drawHistogram1.Size = new System.Drawing.Size(500, 480);
            this.drawHistogram1.TabIndex = 28;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 670);
            this.Controls.Add(this.drawHistogram1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Otsu`s method for grayscale images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OriginalImage64;
        private System.Windows.Forms.Button GrayImage64;
        private System.Windows.Forms.Button OriginalImage32;
        private System.Windows.Forms.Button GrayImage32;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DrawHistogram risuvaneNaHistograma1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TwoClassesThreshold32;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Image_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_Image_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_StripMenuItem;
        private System.Windows.Forms.Button TwoClassesThreshold64;
        private System.Windows.Forms.Button OriginalImage256;
        private System.Windows.Forms.Button TwoClassesThreshold256;
        private System.Windows.Forms.Button GrayImage256;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ThreeCLassesThreshold256;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ThreeClassesThreshold32;
        private System.Windows.Forms.Button FourClassesThreshold32;
        private System.Windows.Forms.Button FourClassesThreshold64;
        private System.Windows.Forms.Button ThreeClassesThreshold64;
        private System.Windows.Forms.Button FourClassesThreshold256;
        private DrawHistogram drawHistogram1;
    }
}

