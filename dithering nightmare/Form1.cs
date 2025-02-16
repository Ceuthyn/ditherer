using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dithering_nightmare{
    public partial class Form1: Form{
        List<Color> palette = new List<Color>{Color.FromArgb(0,0,0),Color.FromArgb(255,255,255)};
        Bitmap img;
        Bitmap outp;
        Int16 bright = 128;
        Double contr = 1;
        public Form1(){
            InitializeComponent();
            upddat();
        }

        private void imgsel_Click(object sender, EventArgs e){
            try{
                var filsel = new OpenFileDialog();
                filsel.Filter = "png files (*.png)|*.png";
                if (filsel.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.img = new Bitmap(filsel.FileName);
            } catch (Exception){
                MessageBox.Show("uh oh", "app broke call a doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //idk man just fail
            }
            inpbox.Image = this.img;
            rend();
        }

        private void upddat() {
            List<Panel> p = new List<Panel>();
            datv.Controls.Clear();
            for (int i = 0; i < this.palette.Count; i++) {
                p.Add(new Panel());
                p[i].BackColor = this.palette[i];
                p[i].Dock = DockStyle.Fill;
                p[i].Name = "panel" + i;
                datv.Controls.Add(p[i]);
            }
            datv.ColumnCount = (int) Math.Ceiling((double) this.palette.Count / 2);
            datv.RowCount = 2;
            datv.RowStyles.Clear();
            datv.ColumnStyles.Clear();
            for(int i = 0; i<2; i++){
                datv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            }
            for (int i = 0; i < datv.ColumnCount; i++){
                System.Diagnostics.Debug.WriteLine(datv.ColumnCount);
                datv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100/datv.ColumnCount));
            }
        }
        private void saveimg_Click(object sender, EventArgs e){
            try{
                if (this.outp == null) return;
                var downl = new SaveFileDialog();
                downl.Filter = "PNG files (*.png)|*.png";
                downl.Title = "save image";
                downl.RestoreDirectory = true;
                downl.OverwritePrompt = true;
                if(downl.ShowDialog() == DialogResult.OK){
                    outp.Save(downl.FileName, ImageFormat.Png); //no other formats because they suck
                }
            } catch (Exception) { } // bad but dont care rn
            return;
        }

        private void addc_Click(object sender, EventArgs e){
            var colord = new ColorDialog();
            if(colord.ShowDialog() == DialogResult.OK){
                //System.congrDiagnostics.Debug.WriteLine(colord.Color);
                this.palette.Add(colord.Color);
                for(int i = 0; i<this.palette.Count; i++){
                    System.Diagnostics.Debug.WriteLine(this.palette[i]);
                }
                upddat();
                rend();
            }
        }

        private void remc_Click(object sender, EventArgs e){
            if(this.palette.Count != 0) this.palette.RemoveAt(this.palette.Count -1);
            upddat();
            rend();
        }
        private void contrast_Scroll(object sender, EventArgs e){
            Double c = contrast.Value;
            this.contr = (259 * (c*2.55 + 255) / (255 * (259 - c*2.55)));
            System.Diagnostics.Debug.WriteLine(this.contr);
            rend();
        }

        private void brightness_Scroll(object sender, EventArgs e){
            Double b = brightness.Value;
            this.bright = (short) (128 * (1 + (Math.Sign(b/10) * Math.Abs(b/10) * Math.Abs(b/10) )));
            System.Diagnostics.Debug.WriteLine(this.bright);
            rend();
        }

        private Int16 clampedadd(int a, int b, int min, int max){
            return (short)Math.Max(Math.Min(a + b, max), min);
        }

        private Color selc(Int16 r, Int16 g, Int16 b){
            Color opt = Color.FromArgb(255, 255, 0); //if this ever appears without being in the palette, something went wrong
            int minerr = int.MaxValue;
            for(int i = 0; i<this.palette.Count; i++){
                int err = Math.Abs(r - this.palette[i].R) + Math.Abs(g - this.palette[i].G) + Math.Abs(b - this.palette[i].B);
                if(err < minerr){
                    minerr = err;
                    opt = this.palette[i];
                    if (err <= 1) return opt;
                 }
            }
            return opt;
        }

        private void rend(){
            if(this.palette.Count <= 0 || this.img == null){
                //MessageBox.Show("error", "add more colors before trying to dither", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            outp = new Bitmap(this.img.Width, this.img.Height);
            Int16[] err = new Int16[this.img.Width * this.img.Height * 4]; //probably not the best option meh
            for(int y = 0; y<this.img.Height; y++){
                for(int x = 0; x<this.img.Width; x++){
                    Color p = this.img.GetPixel(x, y);
                    err[(x + y * this.img.Width) * 4] = p.R;
                    err[(x + y * this.img.Width) * 4 +1] = p.G;
                    err[(x + y * this.img.Width) * 4 +2] = p.B;
                    err[(x + y * this.img.Width) * 4 +3] = p.A;
                }
            }
            for(int y = 0; y<this.img.Height; y++){
                for(int x = 0; x<this.img.Width; x++){
                    Int16 r = clampedadd((Int16)(this.contr * (err[(x + y * this.img.Width) * 4] - 128)), this.bright, 0, 768);
                    Int16 g = clampedadd((Int16)(this.contr * (err[(x + y * this.img.Width) * 4 + 1] - 128)), this.bright, 0, 768);
                    Int16 b = clampedadd((Int16)(this.contr * (err[(x + y * this.img.Width) * 4 + 2] - 128)), this.bright, 0, 768);
                    Color col = selc(r,g,b);

                    outp.SetPixel(x, y, Color.FromArgb(img.GetPixel(x,y).A, col));
                    Int16 errr = (short)(r - col.R);
                    Int16 errg = (short)(g - col.G);
                    Int16 errb = (short)(b - col.B);

                    if(x != 0 && y != this.img.Width - 1){
                        err[(x - 1 + (y + 1) * this.img.Width) * 4] = clampedadd(err[(x - 1 + (y + 1) * this.img.Width) * 4], errr * 3 / 16, 0, 768);
                        err[(x - 1 + (y + 1) * this.img.Width) * 4 +1] = clampedadd(err[(x - 1 + (y + 1) * this.img.Width) * 4 + 1], errg * 3 / 16, 0, 768);
                        err[(x - 1 + (y + 1) * this.img.Width) * 4 +2] = clampedadd(err[(x - 1 + (y + 1) * this.img.Width) * 4 + 2], errb * 3 / 16, 0, 768);
                    }
                    if (x != this.img.Width-1){
                        err[(x + 1 + (y) * this.img.Width) * 4] = clampedadd(err[(x + 1 + (y) * this.img.Width) * 4], errr * 7 / 16, 0, 768);
                        err[(x + 1 + (y) * this.img.Width) * 4 + 1] = clampedadd(err[(x + 1 + (y) * this.img.Width) * 4 + 1], errg * 7 / 16, 0, 768);
                        err[(x + 1 + (y) * this.img.Width) * 4 + 2] = clampedadd(err[(x + 1 + (y) * this.img.Width) * 4 + 2], errb * 7 / 16, 0, 768);
                    }
                    if (y != this.img.Width - 1){
                        err[(x + (y + 1) * this.img.Width) * 4] = clampedadd(err[(x + (y + 1) * this.img.Width) * 4], errr * 5 / 16, 0, 768);
                        err[(x + (y + 1) * this.img.Width) * 4 + 1] = clampedadd(err[(x + (y + 1) * this.img.Width) * 4 + 1], errg * 5 / 16, 0, 768);
                        err[(x + (y + 1) * this.img.Width) * 4 + 2] = clampedadd(err[(x + (y + 1) * this.img.Width) * 4 + 2], errb * 5 / 16, 0, 768);
                    }
                    if (x != this.img.Width-1 && y != this.img.Width - 1)
                    {
                        err[(x + 1 + (y + 1) * this.img.Width) * 4] = clampedadd(err[(x + 1 + (y + 1) * this.img.Width) * 4], errr * 1 / 16, 0, 768);
                        err[(x + 1 + (y + 1) * this.img.Width) * 4 + 1] = clampedadd(err[(x + 1 + (y + 1) * this.img.Width) * 4 + 1], errg * 1 / 16, 0, 768);
                        err[(x + 1 + (y + 1) * this.img.Width) * 4 + 2] = clampedadd(err[(x + 1 + (y + 1) * this.img.Width) * 4 + 2], errb * 1 / 16, 0, 768);
                    }

                }
            }
            outpbox.Image = outp;

        }
    }
}
