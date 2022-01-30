using Ohmaze_level_maker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohmaze_level_maker
{
    public partial class Form1 : Form
    {
        int mx, my;int[,] lines;int selector = 1;int k1x = 0;int k1y = 0;int k2x = 0; int k2y = 0;
        int k3x = 0; int k3y = 0; int l1x = 0; int l1y = 0; int l2x = 0; int l2y = 0;int c1x = 0;int c1y = 0;int bx = 0;int by = 0;
        int l3x = 0; int l3y = 0;
        public static Image tileme, tilewall, tilemystery, tilefinish, tileredkey, tileredlock, tilebluekey, tilebluelock,
            tilegreenkey, tilegreenlock, tileplatev, tileplateh,tilebee,tilecol;

        private void button9_Click(object sender, EventArgs e)
        {
            selector = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(mx*24, my*24);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Save image";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the  
                // File type selected in the dialog box.  
                // NOTE that the FilterIndex property is one-based.  
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmp.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
            //bmp.Save(@"C:\Users\hp\Desktop\50.png");
            
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "Text file|*.txt";
            saveFileDialog2.Title = "Save code";
            saveFileDialog2.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            
                if (saveFileDialog2.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog2.OpenFile()))
                    {
                        sw.Write(result.Text);
                    }
                }
           

            /* https ://stackoverflow.com/questions/18956737/save-as-dialog-to-save-textbox-data-into-a-file */
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selector = 15;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selector = 16;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selector = 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selector=7 ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selector = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selector = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selector = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selector = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selector = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selector = 0;
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            int nx = (int) e.X/24;
            int ny = (int)e.Y / 24;
            if (nx < (mx - 1) && ny < (my - 1) && nx != 0 && ny != 0 && !(nx == 1 && ny == 1))
            {
                if (selector != 15) { 
                switch (lines[ny, nx])
                {
                    case 4:
                        l1x = 0; l1y = 0;
                        break;
                    case 5:
                        k1x = 0; k1y = 0;
                        break;
                    case 6:
                        l2x = 0; l2y = 0;
                        break;
                    case 7:
                        k2x = 0; k2y = 0;
                        break;
                    case 8:
                        l3x = 0; l3y = 0;
                        break;
                    case 9:
                        k3x = 0; k3y = 0;
                        break;
                }
            }
                switch (selector)
                {
                    case 0:
                        lines[ny, nx] = 0;
                        if (bx==nx&&by==ny) { bx = 0;by = 0; }
                        if (c1x == nx && c1y == ny) { c1x = 0; c1y = 0; }
                        break;
                    case 1:
                        lines[ny, nx] = 1;
                        break;
                    case 3:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 3) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 3;
                        break;
                    case 4:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 4) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 4;
                        l1x = nx; l1y = ny;
                        break;
                    case 5:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 5) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 5;
                        k1x = nx; k1y = ny;
                        break;
                    case 6:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 6) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 6;
                        l2x = nx; l2y = ny;
                        break;
                    case 7:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 7) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 7;
                        k2x = nx; k2y = ny;
                        break;
                    case 8:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 8) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 8;
                        l3x = nx; l3y = ny;
                        break;
                    case 9:
                        for (int i = 0; i < my; i++)
                        {
                            for (int j = 0; j < mx; j++)
                            {
                                if (lines[i, j] == 9) { lines[i, j] = 0; }
                            }
                        }
                        lines[ny, nx] = 9;
                        k3x = nx; k3y = ny;
                        break;
                    case 15:
                        if (lines[ny, nx] == 0)
                        { c1x = nx; c1y = ny; }
                        else { selector = 15; }
                        break;
                    case 16:
                        if (lines[ny, nx] == 0)
                        { bx = nx; by = ny; }
                        else { selector = 16; }
                        break;
                    default:
                        selector = 0;
                        break;
                }
                if (lines[c1y,c1x] != 0 && !(c1x==0 && c1y==0)) { c1x = 0;c1y = 0; }
                if (lines[by, bx] != 0 && !(bx == 0 && by == 0)) { bx = 0; by = 0; }
                string res = "map = new int[][]{\r\n";
                for (int i = 0; i < my; i++)
                {
                    res += "{";
                    for (int j = 0; j < mx; j++)
                    {
                        res += lines[i, j].ToString();
                        if (j < (mx - 1)) { res += ","; }

                    }
                    res += "}";
                    if (i < (my - 1)) { res += ","; }
                    res += "\r\n";
                }
                res += "};\r\n";
                res += "l1x = " + l1x + "; l1y = " + l1y + ";\r\n";
                res += "l2x = " + l2x + "; l2y = " + l2y + ";\r\n";
                res += "l3x = " + l3x + "; l3y = " + l3y + ";\r\n";
                res += "k1x = " + k1x + "; k1y = " + k1y + ";\r\n";
                res += "k2x = " + k2x + "; k2y = " + k2y + ";\r\n";
                res += "k3x = " + k3x + "; k3y = " + k3y + ";\r\n";
                res += "c1x = " + c1x + "; c1y = " + c1y + ";\r\n";
                if (bx != 0 && by != 0) {
                    res += "bx = " + bx + "; by = " + by + ";\r\n";
                }
                res += "mx = " + mx + "; my = " + my + ";\r\n";
                res += "cd = 120; //TODO: change to a sutiable time\r\n";
                result.Text = res;
                this.Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void generator_Click(object sender, EventArgs e)
        {
            try
            {
                mx = Convert.ToInt32(mWidth.Text);
                my = Convert.ToInt32(mHeight.Text);
                if (mx > 25) { mx = 25; mWidth.Text = "25"; }
                if (my > 27) { my = 27; mHeight.Text = "27"; }
                save_code.Enabled = true;
                save_image.Enabled = true;
            }catch(Exception ex){ mx = 0;my = 0; }
            lines = new int[my, mx];int ix = my - 1;int jx = mx - 1;
            for (int i = 0; i < my; i++) {
                for(int j = 0; j < mx; j++)
                {
                    if (i == 0 || j == 0 || i == ix || j==jx) { lines[i, j] = 1; }
                    else { lines[i, j] = 0; }

                }
            }string res = "map = new int[][]{\r\n";
            for (int i = 0; i < my; i++)
            {
                res += "{";
                for (int j = 0; j < mx; j++)
                {
                    res += lines[i, j].ToString();
                    if (j < jx) { res += ","; }

                }
                res += "}";
                if (i < ix) { res += ","; }
                res +="\r\n";
            }res += "};\r\n";
            res += "l1x = " + l1x + "; l1y = " + l1y + ";\r\n";
            res += "l2x = " + l2x + "; l2y = " + l2y + ";\r\n";
            res += "l3x = " + l3x + "; l3y = " + l3y + ";\r\n";
            res += "k1x = " + k1x + "; k1y = " + k1y + ";\r\n";
            res += "k2x = " + k2x + "; k2y = " + k2y + ";\r\n";
            res += "k3x = " + k3x + "; k3y = " + k3y + ";\r\n";
            res += "c1x = " + c1x + "; c1y = " + c1y + ";\r\n";
            res += "p1x = 1; p1y = 1;\r\n";
            res += "p2x = 1; p2y = 1;\r\n";
            res += "mx = " + mx + "; my = " + my + ";\r\n";
            res += "cd = 120; //TODO: change to a sutiable time\r\n";
            result.Text = res;
            
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(pictureBox1_Click);
            this.Refresh();
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            /* g.DrawString("This is a diagonal line drawn on the control",
                 new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));*/
            // Draw a line in the PictureBox.
            tileme = Resources.me;
            tilewall = Resources.wall;
            tilefinish = Resources.finish;
            tileredlock = Resources.lock_red;
            tileredkey = Resources.key_red;
            tilebluelock = Resources.lock_blue;
            tilebluekey = Resources.key_blue;
            tilegreenlock = Resources.lock_green;
            tilegreenkey = Resources.key_green;
            tilebee = Resources.bee_up;
            tilecol = Resources.p6;
            try
            {
                int width = mx;
                int height = my;
                e.Graphics.DrawImage(tileme, 24,24, 24, 24);
                int px = 1;
                int py = 1;
                if (c1x != 0 && c1y != 0) { e.Graphics.DrawImage(tilecol, c1x * 24, c1y * 24, 24, 24); }
                if (bx!=0 && by!=0) { e.Graphics.DrawImage(tilebee, bx*24, by*24, 24, 24); }
                for (int j = 0; j < width; j++)
                {
                    for (int i = 0; i < height; i++)
                    {


                        if (i < height)
                        {
                            float tileX = j * 24;
                            float tileY = i * 24;
                            int type = lines[i, j];
                            switch (type)
                            {
                                case 1:
                                    e.Graphics.DrawImage(tilewall, tileX, tileY, 24, 24);
                                    break;
                                case 3:
                                    e.Graphics.DrawImage(tilefinish, tileX, tileY, 24, 24);
                                    break;
                                case 4:
                                    e.Graphics.DrawImage(tilebluelock, tileX, tileY, 24, 24);
                                    break;
                                case 5:
                                    e.Graphics.DrawImage(tilebluekey, tileX, tileY, 24, 24);
                                    break;
                                case 6:
                                    e.Graphics.DrawImage(tileredlock, tileX, tileY, 24, 24);
                                    break;
                                case 7:
                                    e.Graphics.DrawImage(tileredkey, tileX, tileY, 24, 24);
                                    break;
                                case 8:
                                    e.Graphics.DrawImage(tilegreenlock, tileX, tileY, 24, 24);
                                    break;
                                case 9:
                                    e.Graphics.DrawImage(tilegreenkey, tileX, tileY, 24, 24);
                                    break;
                            }
                        }

                    }
                }
                try
                {
                    Thread.Sleep(17);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
