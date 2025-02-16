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
            this.outpbox = new System.Windows.Forms.PictureBox();
            this.inpbox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveimg = new System.Windows.Forms.Button();
            this.imgsel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contrast = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brightness = new System.Windows.Forms.TrackBar();
            this.addc = new System.Windows.Forms.Button();
            this.remc = new System.Windows.Forms.Button();
            this.datv = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.outpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpbox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outpbox
            // 
            this.outpbox.BackColor = System.Drawing.Color.Gray;
            this.outpbox.Location = new System.Drawing.Point(6, 19);
            this.outpbox.Name = "outpbox";
            this.outpbox.Size = new System.Drawing.Size(254, 254);
            this.outpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outpbox.TabIndex = 8;
            this.outpbox.TabStop = false;
            // 
            // inpbox
            // 
            this.inpbox.BackColor = System.Drawing.Color.Gray;
            this.inpbox.Location = new System.Drawing.Point(6, 19);
            this.inpbox.Name = "inpbox";
            this.inpbox.Size = new System.Drawing.Size(254, 254);
            this.inpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inpbox.TabIndex = 9;
            this.inpbox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.inpbox);
            this.groupBox4.Location = new System.Drawing.Point(12, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 292);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "input";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.outpbox);
            this.groupBox5.Location = new System.Drawing.Point(278, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 292);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "output";
            // 
            // saveimg
            // 
            this.saveimg.Location = new System.Drawing.Point(294, 3);
            this.saveimg.Name = "saveimg";
            this.saveimg.Size = new System.Drawing.Size(47, 80);
            this.saveimg.TabIndex = 5;
            this.saveimg.Text = "save image";
            this.saveimg.UseVisualStyleBackColor = true;
            this.saveimg.Click += new System.EventHandler(this.saveimg_Click);
            // 
            // imgsel
            // 
            this.imgsel.Location = new System.Drawing.Point(247, 3);
            this.imgsel.Name = "imgsel";
            this.imgsel.Size = new System.Drawing.Size(47, 80);
            this.imgsel.TabIndex = 4;
            this.imgsel.Text = "select image";
            this.imgsel.UseVisualStyleBackColor = true;
            this.imgsel.Click += new System.EventHandler(this.imgsel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.contrast);
            this.groupBox2.Location = new System.Drawing.Point(125, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "contrast";
            // 
            // contrast
            // 
            this.contrast.AutoSize = false;
            this.contrast.BackColor = System.Drawing.Color.Gray;
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.brightness);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "brightness";
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
            // addc
            // 
            this.addc.Location = new System.Drawing.Point(474, 3);
            this.addc.Name = "addc";
            this.addc.Size = new System.Drawing.Size(53, 38);
            this.addc.TabIndex = 8;
            this.addc.Text = "add color";
            this.addc.UseVisualStyleBackColor = true;
            this.addc.Click += new System.EventHandler(this.addc_Click);
            // 
            // remc
            // 
            this.remc.Location = new System.Drawing.Point(474, 45);
            this.remc.Name = "remc";
            this.remc.Size = new System.Drawing.Size(53, 38);
            this.remc.TabIndex = 9;
            this.remc.Text = "remove color";
            this.remc.UseVisualStyleBackColor = true;
            this.remc.Click += new System.EventHandler(this.remc_Click);
            // 
            // datv
            // 
            this.datv.BackColor = System.Drawing.Color.Silver;
            this.datv.CausesValidation = false;
            this.datv.ColumnCount = 2;
            this.datv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.datv.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.datv.Location = new System.Drawing.Point(347, 3);
            this.datv.Name = "datv";
            this.datv.RowCount = 2;
            this.datv.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.datv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.datv.Size = new System.Drawing.Size(121, 80);
            this.datv.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.remc);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.addc);
            this.panel1.Controls.Add(this.datv);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.imgsel);
            this.panel1.Controls.Add(this.saveimg);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 86);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(555, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "ditherer";
            ((System.ComponentModel.ISupportInitialize)(this.outpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpbox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox outpbox;
        private System.Windows.Forms.PictureBox inpbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button saveimg;
        private System.Windows.Forms.Button imgsel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar contrast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.Button addc;
        private System.Windows.Forms.Button remc;
        private System.Windows.Forms.TableLayoutPanel datv;
        private System.Windows.Forms.Panel panel1;
    }
}

