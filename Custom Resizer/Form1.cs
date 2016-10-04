using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        Boolean bHaveMouse;
        Point ptOriginal = new Point();
        Point ptLast = new Point();
        //Point p1 = new Point();
        //Point p2 = new Point();
        //int novasirina = 1 ;

        //int novavisina = 1 ;
        int starasirina  ;
        int staravisina  ;
        int delilacX = 1;
        int delilacY = 1;
        int komponentaboje = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pictureBox1.ImageLocation = "F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg";
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            //xlabel.Text = "1";
            //ylabel.Text = "1";
            //newXlabel.Text = "1";
            //newYlabel.Text = "1";
        }

        private void openbutton1_Click(object sender, EventArgs e)
        {

            DialogResult ucitano = openFileDialog1.ShowDialog();

            if (ucitano == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                string lokacija = openFileDialog1.FileName;

                Bitmap novaslika = (Bitmap) Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);
                xlabel.Text = Convert.ToString(novaslika.Width);
                ylabel.Text = Convert.ToString(novaslika.Height);

 

             }


            }

        private void MyDrawReversibleRectangle(Point p1, Point p2, int novasirina, int novavisina)
        {
            
            
            Bitmap myBitmap = new Bitmap(this.pictureBox1.Image, this.pictureBox1.Width, this.pictureBox1.Height);

            
            using (Graphics g = Graphics.FromImage(myBitmap))
            {

                
                g.FillRectangle(new SolidBrush(Color.FromArgb(3, 255, komponentaboje, komponentaboje)), p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                g.Dispose();
                
            }

            

            //newXlabel.Text = Convert.ToString(novasirina);
            //newYlabel.Text = Convert.ToString(novavisina);
            starasirina = this.pictureBox1.Width;
            staravisina = this.pictureBox1.Height;

            if (starasirina == 0)
            {
                starasirina = 1;
                    
            }

            if (staravisina == 0)
            {
                staravisina = 1;

            }

            if (novasirina == 0 )
            {
                novasirina = 1;
                
            }
            if (novavisina == 0)
            {
                novavisina = 1;

            }


            if (starasirina == 0)
            {
                starasirina = 1;
                
            }

            if (staravisina == 0)
            {
                staravisina = 1;

            }

            delilacX = Convert.ToInt32(Math.Round(Convert.ToDecimal(starasirina / novasirina)));
            delilacY = Convert.ToInt32(Math.Round(Convert.ToDecimal(staravisina / novavisina)));

            if (delilacX == 0)

            {
                delilacX = 1;            
            }

            if (delilacY == 0)
            {
                delilacY = 1;
            }

            int newnovasirina = Convert.ToInt32(xlabel.Text);
            int newnovavisina = Convert.ToInt32(ylabel.Text);
            newXlabel.Text = Convert.ToString(newnovasirina / delilacX);
            newYlabel.Text = Convert.ToString(newnovavisina / delilacY);
            infolabel.Text = delilacX + " By X   " + delilacY + " By Y";
            

            this.pictureBox1.Image = myBitmap;
            
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);
            if (bHaveMouse)
            {
                if (ptLast.X != -1)
                {
                    MyDrawReversibleRectangle(ptOriginal, ptLast, (ptLast.X - ptOriginal.X) + 1, (ptLast.Y - ptOriginal.Y) + 1);
                }
                ptLast = ptCurrent;
                MyDrawReversibleRectangle(ptOriginal, ptCurrent, (ptLast.X - ptOriginal.X) + 1, (ptLast.Y - ptOriginal.Y) + 1);
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bHaveMouse = true;
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;
            ptLast.X = -1;
            ptLast.Y = -1;
            //Bitmap novaslika = (Bitmap)Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);
            //this.pictureBox1.Image = Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);

        
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bHaveMouse = false;
            if (ptLast.X != -1)
            {
                Point ptCurrent = new Point(e.X, e.Y);

               // pictureBox1.Image.Dispose();
                pictureBox1.Update();
                komponentaboje = komponentaboje + 15;

                if (komponentaboje == 255)
                {
                    komponentaboje = 0;
                }
                MyDrawReversibleRectangle(ptOriginal, ptLast, (ptLast.X - ptOriginal.X)+1, (ptLast.Y - ptOriginal.Y)+1);
            }
            ptLast.X = -1;
            ptLast.Y = -1;
            ptOriginal.X = -1;
            ptOriginal.Y = -1;
        }

        private void resizebutton1_Click(object sender, EventArgs e)
        {

            

            if (pictureBox1.ImageLocation == "F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg")

            {
                MessageBox.Show("Not good, Picture is default picture");

                return;
            }
            
            
            
            Image novaslika1 = Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);
            if (novaslika1.Height == 0)
            {
                novaslika1 = Image.FromFile("F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg", true);

            }
            
            
            xlabel.Text = Convert.ToString(novaslika1.Width);
            ylabel.Text = Convert.ToString(novaslika1.Height);

            int xsirina = Convert.ToInt32(newXlabel.Text);
            int ysirina = Convert.ToInt32(newYlabel.Text);

            if (xsirina > 1)
            {
                novaslika1 = resizeImage(novaslika1, new Size(xsirina, ysirina));
                MessageBox.Show("New resized image will be X: " + xsirina + "  Y: " + ysirina);
            }

            if (xsirina <= 1)
            {

                MessageBox.Show("Not good, Picture is default picture");
            }
           

                
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

      


        private void savebutton1_Click(object sender, EventArgs e)
            {

                if (pictureBox1.ImageLocation == "F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg")
                {
                    MessageBox.Show("Not good, Picture is default picture");

                    return;
                }

                Image novaslika1 = Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);

                if (novaslika1.Height == 0)
                {
                    novaslika1 = Image.FromFile("F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg", true);

                }
                xlabel.Text = Convert.ToString(novaslika1.Width);
                ylabel.Text = Convert.ToString(novaslika1.Height);

                int xsirina = Convert.ToInt32(newXlabel.Text);
                int ysirina = Convert.ToInt32(newYlabel.Text);

                novaslika1 = resizeImage(novaslika1, new Size(xsirina, ysirina));

                


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.jpg;*.bmp;*.png";
                ImageFormat format = ImageFormat.Jpeg;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    novaslika1.Save(sfd.FileName, format);
                    MessageBox.Show("New saved image is  X: " + xsirina + "  Y: " + ysirina);
                }


            }

        private void clearbutton_Click(object sender, EventArgs e)
        {

            //pictureBox1.ImageLocation = "F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg";

            //xlabel.Text = "1";
            //ylabel.Text = "1";

            pictureBox1.ImageLocation = openFileDialog1.FileName;

            

            if (pictureBox1.ImageLocation == "openFileDialog1")
            {
                pictureBox1.ImageLocation = "F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg";
            }

            newXlabel.Text = "1";
            newYlabel.Text = "1";
            infolabel.Text = "1";
        }
        
 

        // Metoda za resize
        //public void resizerdeo()
        //{
        //    Image novaslika1 = Image.FromFile(Convert.ToString(pictureBox1.ImageLocation), true);

        //    if (novaslika1.Height == 0)
        //    {
        //        novaslika1 = Image.FromFile("F:\\VSTUDIO\\CSHARP\\Custom Resizer\\Custom Resizer\\Resources\\SLIKAINICIJALNA.jpg", true);

        //    }
        //    xlabel.Text = Convert.ToString(novaslika1.Width);
        //    ylabel.Text = Convert.ToString(novaslika1.Height);

        //    int xsirina = Convert.ToInt32(newXlabel.Text);
        //    int ysirina = Convert.ToInt32(newYlabel.Text);

        //    novaslika1 = resizeImage(novaslika1, new Size(xsirina, ysirina));

        //}
        //public  void Kloniranje(PaintEventArgs e)
        //{
        //    Bitmap myBitmap = new Bitmap(openFileDialog1.FileName);
        //    Rectangle cloneRect = new Rectangle(0, 0, 100, 100);
        //    Bitmap novaslika = myBitmap.Clone(cloneRect, myBitmap.PixelFormat);

        //    e.Graphics.DrawImage(novaslika, 0, 0);

        //}

        
            //Rectangle mRect;

            //protected  void pictureBox1_MouseDown(object sender, MouseEventArgs e)
            //{
            //    mRect = new Rectangle(e.X, e.Y, 0, 0);
            //    this.Invalidate();
            //}
            ////check if mouse is down and being draged, then draw rectangle
            //private  void pictureBox1_MouseMove(object sender, MouseEventArgs e)
            //{
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        mRect = new Rectangle(mRect.Left, mRect.Top, e.X - mRect.Left, e.Y - mRect.Top);
            //        this.Invalidate();
            //    }
            //}

            ////draw the rectangle on paint event
            //protected override void OnPaint(PaintEventArgs e)
            //{
            //    //Draw a rectangle with 2pixel wide line
            //    using (Pen pen = new Pen(Color.Red, 2))
            //    {
            //        e.Graphics.DrawRectangle(pen, mRect);
            //    }

            




        }


                              
    }
                

       
    
                    
 




 

        








