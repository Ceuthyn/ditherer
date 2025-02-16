namespace dithering_nightmare
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
            this.brightness = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contrast = new System.Windows.Forms.TrackBar();
            this.imgsel = new System.Windows.Forms.Button();
            this.saveimg = new System.Windows.Forms.Button();
            this.outpbox = new System.Windows.Forms.PictureBox();
            this.inpbox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datv = new System.Windows.Forms.TableLayoutPanel();
            this.remc = new System.Windows.Forms.Button();
            this.addc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpbox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightness
            // 
            this.brightness.AutoSize = false;
            this.brightness.Location = new System.Drawing.Point(6, 19);
            this.brightness.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.brightness.Minimum = -10;
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(104, 45);
            this.brightness.TabIndex = 0;
            this.brightness.TickFrequency = 2;
            this.brightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.brightness.Scroll += new System.EventHandler(this.brightness_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.brightness);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "brightness";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.contrast);
            this.groupBox2.Location = new System.Drawing.Point(128, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "contrast";
            // 
            // contrast
            // 
            this.contrast.AutoSize = false;
            this.contrast.Location = new System.Drawing.Point(6, 19);
            this.contrast.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.contrast.Maximum = 50;
            this.contrast.Minimum = -100;
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(104, 45);
            this.contrast.TabIndex = 0;
            this.contrast.TickFrequency = 20;
            this.contrast.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.contrast.Scroll += new System.EventHandler(this.contrast_Scroll);
            // 
            // imgsel
            // 
            this.imgsel.Location = new System.Drawing.Point(250, 14);
            this.imgsel.Name = "imgsel";
            this.imgsel.Size = new System.Drawing.Size(47, 80);
            this.imgsel.TabIndex = 4;
            this.imgsel.Text = "select image";
            this.imgsel.UseVisualStyleBackColor = true;
            this.imgsel.Click += new System.EventHandler(this.imgsel_Click);
            // 
            // saveimg
            // 
            this.saveimg.Location = new System.Drawing.Point(303, 14);
            this.saveimg.Name = "saveimg";
            this.saveimg.Size = new System.Drawing.Size(47, 80);
            this.saveimg.TabIndex = 5;
            this.saveimg.Text = "save image";
            this.saveimg.UseVisualStyleBackColor = true;
            this.saveimg.Click += new System.EventHandler(this.saveimg_Click);
            // 
            // outpbox
            // 
            this.outpbox.Location = new System.Drawing.Point(6, 19);
            this.outpbox.Name = "outpbox";
            this.outpbox.Size = new System.Drawing.Size(254, 246);
            this.outpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outpbox.TabIndex = 8;
            this.outpbox.TabStop = false;
            // 
            // inpbox
            // 
            this.inpbox.Location = new System.Drawing.Point(6, 19);
            this.inpbox.Name = "inpbox";
            this.inpbox.Size = new System.Drawing.Size(254, 246);
            this.inpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inpbox.TabIndex = 9;
            this.inpbox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.datv);
            this.groupBox3.Controls.Add(this.remc);
            this.groupBox3.Controls.Add(this.addc);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.imgsel);
            this.groupBox3.Controls.Add(this.saveimg);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox3.Size = new System.Drawing.Size(542, 110);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // datv
            // 
            this.datv.CausesValidation = false;
            this.datv.ColumnCount = 2;
            this.datv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datv.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.datv.Location = new System.Drawing.Point(356, 14);
            this.datv.Name = "datv";
            this.datv.RowCount = 2;
            this.datv.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.datv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.datv.Size = new System.Drawing.Size(121, 80);
            this.datv.TabIndex = 10;
            // 
            // remc
            // 
            this.remc.Location = new System.Drawing.Point(483, 56);
            this.remc.Name = "remc";
            this.remc.Size = new System.Drawing.Size(53, 38);
            this.remc.TabIndex = 9;
            this.remc.Text = "remove color";
            this.remc.UseVisualStyleBackColor = true;
            this.remc.Click += new System.EventHandler(this.remc_Click);
            // 
            // addc
            // 
            this.addc.Location = new System.Drawing.Point(483, 14);
            this.addc.Name = "addc";
            this.addc.Size = new System.Drawing.Size(53, 38);
            this.addc.TabIndex = 8;
            this.addc.Text = "add color";
            this.addc.UseVisualStyleBackColor = true;
            this.addc.Click += new System.EventHandler(this.addc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.inpbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 284);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "input";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.outpbox);
            this.groupBox5.Location = new System.Drawing.Point(288, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 284);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "ditherer";
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpbox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar contrast;
        private System.Windows.Forms.Button imgsel;
        private System.Windows.Forms.Button saveimg;
        private System.Windows.Forms.PictureBox outpbox;
        private System.Windows.Forms.PictureBox inpbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button remc;
        private System.Windows.Forms.Button addc;
        private System.Windows.Forms.TableLayoutPanel datv;
    }
}

