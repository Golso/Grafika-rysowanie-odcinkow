using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odcinek
{
    public partial class Form1 : Form
    {
        Point p1, p2;
        bool click = false;
        int algorytm = 0;
        bool wsp = true;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(wsp)
                if (click==false)
                {
                    p1 = e.Location;
                    click = true;
                    label1.Text = "X: " + p1.X + ", Y: " + p1.Y;
                }
                else
                {
                    p2 = e.Location;
                    click = false;
                    label2.Text = "X: " + p2.X + ", Y: " + p2.Y;
                    if (algorytm == 0)
                        pktSrodkowy(p1, p2);
                    else
                        przyrostowy(p1, p2);
                }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            try
            {
                if (click == true)
                    bmp.SetPixel(p1.X, p1.Y, Color.Black);
                else
                    bmp.SetPixel(p2.X, p2.Y, Color.Black);
            }
            catch (ArgumentOutOfRangeException)
            {
                Wyjatek.Text = "Błędnie podane współrzędne.";
            }
            pictureBox1.Image = bmp;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            p1.X = 0;
            p1.Y = 0;
            p2.X = 0;
            p2.Y = 0;
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxY1.Text = "";
            textBoxY2.Text = "";
            Wyjatek.Text = "";
            label1.Text = "X: " + p1.X + ", Y: " + p1.Y;
            label2.Text = "X: " + p2.X + ", Y: " + p2.Y;
            click = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            algorytm = 0;
            wybAlg.Text = "Z punktem środkowym";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            algorytm = 1;
            wybAlg.Text = "Przyrostowy";
        }

        void pktSrodkowy(Point p1, Point p2)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            
            int d, dx, dy, incrNE, incrE, xi, yi;
            int x = p1.X, y = p1.Y;

            xi = p1.X < p2.X ? 1 : -1;
            dx = p1.X < p2.X ? p2.X - p1.X : p1.X - p2.X;

            yi = p1.Y < p2.Y ? 1 : -1;
            dy = p1.Y < p2.Y ? p2.Y - p1.Y : p1.Y - p2.Y;
            
            bmp.SetPixel(x, y, Color.Blue);
            if (dx > dy)
            {
                d = dy * 2 - dx;
                incrE = dy * 2;
                incrNE = (dy - dx) * 2;

                while (x != p2.X)
                {
                    if (d <= 0)
                    {
                        d += incrE;
                        x += xi;
                    }
                    else
                    {
                        d += incrNE;
                        x += xi;
                        y += yi;
                    }
                    bmp.SetPixel(x, y, Color.Blue);
                }
            }
            else
            {
                d = dx * 2 - dy;
                incrE = dx * 2;
                incrNE = (dx - dy) * 2;

                while (y != p2.Y)
                {
                    if (d <= 0)
                    {
                        d += incrE;
                        y += yi;
                    }
                    else
                    {
                        d += incrNE;
                        x += xi;
                        y += yi;
                    }
                    bmp.SetPixel(x, y, Color.Blue);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void WspButton_Click(object sender, EventArgs e)
        {
            wsp = false;
            textBoxX1.ReadOnly = false;
            textBoxX2.ReadOnly = false;
            textBoxY1.ReadOnly = false;
            textBoxY2.ReadOnly = false;
            RysujButton.Enabled = true;
        }

        private void RysownikButton_Click(object sender, EventArgs e)
        {
            wsp = true;
            textBoxX1.ReadOnly = true;
            textBoxX2.ReadOnly = true;
            textBoxY1.ReadOnly = true;
            textBoxY2.ReadOnly = true;
            RysujButton.Enabled = false;
        }

        private void RysujButton_Click(object sender, EventArgs e)
        {
            try
            {
                p1.X = Convert.ToInt32(textBoxX1.Text);
                p2.X = Convert.ToInt32(textBoxX2.Text);
                p1.Y = Convert.ToInt32(textBoxY1.Text);
                p2.Y = Convert.ToInt32(textBoxY2.Text);

                if (algorytm == 0)
                    pktSrodkowy(p1, p2);
                else
                    przyrostowy(p1, p2);

                Wyjatek.Text = "";
            }
            catch (FormatException)
            {
                Wyjatek.Text = "Zły format danych.";
            }
            catch
            {
                Wyjatek.Text = "Błędnie podane współrzędne";
            }
        }

        void przyrostowy(Point p1, Point p2)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            float dy, dx, y, x, m;
            
            dy = p2.Y - p1.Y;
            dx = p2.X - p1.X;

            if (dx != 0)
                m = dy / dx;
            else
                m = dy;

            if (Math.Abs(m) < 1)
            {
                Point start = p1.X < p2.X ? p1 : p2;
                Point end = p1.X >= p2.X ? p1 : p2;
                y = start.Y;
                for (x = start.X; x <= end.X; x++)
                {
                    bmp.SetPixel((int)x, (int)Math.Floor(y + 0.5), Color.Red);
                    y += m;
                }
            }
            else 
            {
                Point start = p1.Y < p2.Y ? p1 : p2;
                Point end = p1.Y >= p2.Y ? p1 : p2;
                x = start.X;
                for (y = start.Y; y<=end.Y; y++)
                {
                    bmp.SetPixel((int)Math.Floor(x + 0.5), (int)y, Color.Red);
                    if (dx != 0)
                        x += 1/m;
                     
                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
