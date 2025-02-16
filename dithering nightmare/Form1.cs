using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dithering_nightmare{
    public partial class Form1: Form{
        List<Color> palette = new List<Color>{Color.FromArgb(0,0,0)};
        Bitmap img;
        Bitmap outp;
        int width;
        int height;
        public Form1(){
            InitializeComponent();
            upddat();
        }

        private void trackBar1_Scroll(object sender, EventArgs e){

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

        private int clampedadd(int a, int b){
            return Math.Max(Math.Min(a + b, 768), 0);
        }



        private void rend(){


        }

    }
}
