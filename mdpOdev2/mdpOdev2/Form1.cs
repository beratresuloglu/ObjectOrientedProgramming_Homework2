/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…............: 2
**				ÖĞRENCİ ADI...............: BERAT RESULOĞLU
**				ÖĞRENCİ NUMARASI..........: B231210050
**				DERS GRUBU…………............: A (CEMİL ÖZ)
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdpOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void noktaDörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Square square = new Square();
            Random rnd = new Random();
            Point point = new Point();

            point.X = rnd.Next(50, 650);
            point.Y = rnd.Next(50, 450);
            square.M.X = rnd.Next(100, 600);
            square.M.Y = rnd.Next(100, 400);
            square.Edge = rnd.Next(50, 200);

            graphics.Clear(Color.White); // veya başka bir renk
            graphics.DrawRectangle(pen, square.M.X, square.M.Y, square.Edge, square.Edge);
            graphics.FillRectangle(brush, point.X, point.Y, 2, 2);

            bool sonuc = Collision.pointSquareCollision(point, square);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void noktaÇemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Circle circle = new Circle();
            Random rnd = new Random();
            Point point = new Point();

            point.X = rnd.Next(50, 600);
            point.Y = rnd.Next(50, 600);
            circle.M.X = rnd.Next(50, 100);
            circle.M.Y = rnd.Next(50, 100);
            circle.R = rnd.Next(100, 150);

            graphics.Clear(Color.White); // veya başka bir renk
            graphics.DrawEllipse(pen, circle.M.X, circle.M.Y, circle.R, circle.R);
            graphics.FillRectangle(brush, point.X, point.Y, 2, 2);

            bool sonuc = Collision.pointCircleCollision(point, circle);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void dikdörtgenDikdörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            RectangleClass rectangle1 = new RectangleClass();
            RectangleClass rectangle2 = new RectangleClass();
            Random rnd = new Random();

            rectangle1.M.X = rnd.Next(150, 550);
            rectangle1.M.Y = rnd.Next(150, 350);
            rectangle1.Width = rnd.Next(50, 150);
            rectangle1.Height = rnd.Next(50, 150);

            rectangle2.M.X = rnd.Next(150, 550);
            rectangle2.M.Y = rnd.Next(150, 350);
            rectangle2.Width = rnd.Next(50, 150);
            rectangle2.Height = rnd.Next(50, 150);

            graphics.Clear(Color.White); // veya başka bir renk
            graphics.DrawRectangle(pen, rectangle1.M.X, rectangle1.M.Y, rectangle1.Width, rectangle1.Height);
            graphics.DrawRectangle(pen, rectangle2.M.X, rectangle2.M.Y, rectangle2.Width, rectangle2.Height);

            bool sonuc = Collision.rectangleRectangleCollision(rectangle1, rectangle2);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void dikdörtgenÇemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            RectangleClass rectangle = new RectangleClass();
            Circle circle = new Circle();
            Random rnd = new Random();

            rectangle.M.X = rnd.Next(150, 550);
            rectangle.M.Y = rnd.Next(150, 350);
            rectangle.Width = rnd.Next(50, 150);
            rectangle.Height = rnd.Next(50, 150);

            circle.M.X = rnd.Next(150, 550);
            circle.M.Y = rnd.Next(150, 350);
            circle.R = rnd.Next(50, 150);

            graphics.Clear(Color.White); // veya başka bir renk
            graphics.DrawRectangle(pen, rectangle.M.X, rectangle.M.Y, rectangle.Width, rectangle.Height);
            graphics.DrawEllipse(pen, circle.M.X, circle.M.Y, circle.R, circle.R);

            bool sonuc = Collision.rectangleCircleCollision(rectangle, circle);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void çemberÇemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Random rnd = new Random();

            circle1.M.X = rnd.Next(150, 550);
            circle1.M.Y = rnd.Next(150, 350);
            circle1.R = rnd.Next(50, 150);

            circle2.M.X = rnd.Next(150, 550);
            circle2.M.Y = rnd.Next(150, 350);
            circle2.R = rnd.Next(50, 150);

            graphics.Clear(Color.White); // 
            graphics.DrawEllipse(pen, circle1.M.X, circle1.M.Y, circle1.R, circle1.R);
            graphics.DrawEllipse(pen, circle2.M.X, circle2.M.Y, circle2.R, circle2.R);

            bool sonuc = Collision.circleCircleCollision(circle1, circle2);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void noktaKüreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Point3d point = new Point3d();
            Sphere sphere = new Sphere();
            Random rnd = new Random();

            sphere.M.X = rnd.Next(150, 550);
            sphere.M.Y = rnd.Next(150, 350);
            sphere.M.Z = rnd.Next(150, 350);
            sphere.R = rnd.Next(50, 150);

            point.X = rnd.Next(150, 550);
            point.Y = rnd.Next(150, 550);
            point.Z = sphere.M.Z;


            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, point.X, point.Y, 2, 2);
            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y, sphere.R, sphere.R);
            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y + (sphere.R / 4), sphere.R, (sphere.R / 2));

            bool sonuc = Collision.pointSphereCollision(point, sphere);
            if (sonuc)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void noktaDikdörtgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            Point point = new Point();
            RectangleClass rectangle = new RectangleClass();
            Random rnd = new Random();

            point.X = rnd.Next(150, 450);
            point.Y = rnd.Next(150, 350);

            rectangle.M.X = rnd.Next(200, 450);
            rectangle.M.Y = rnd.Next(200, 350);
            rectangle.Width = rnd.Next(50, 150);
            rectangle.Height = rnd.Next(50, 150);

            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, point.X, point.Y, 2, 2);
            graphics.DrawRectangle(pen, rectangle.M.X, rectangle.M.Y, rectangle.Width, rectangle.Height);


            bool sonuc = Collision.pointRectangleCollision(point, rectangle);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void noktaSilindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Point3d point = new Point3d();
            Cylinder cylinder = new Cylinder();
            Random rnd = new Random();

            point.X = rnd.Next(150, 450);
            point.Y = rnd.Next(150, 350);
            point.Z = rnd.Next(150, 350);

            cylinder.M.X = rnd.Next(150, 450);
            cylinder.M.Y = rnd.Next(150, 350);
            cylinder.M.Z = rnd.Next(50, 150);
            cylinder.H = rnd.Next(50, 100);
            cylinder.R = rnd.Next(50, 100);

           
            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, point.X, point.Y, 2, 2);
            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y, cylinder.R, cylinder.R);
            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y + cylinder.H, cylinder.R, cylinder.R);
            graphics.DrawLine(pen, cylinder.M.X, cylinder.M.Y + cylinder.R / 2, cylinder.M.X, cylinder.M.Y + cylinder.H + cylinder.R / 2);
            graphics.DrawLine(pen, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.R / 2, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.H + cylinder.R / 2);

            bool sonuc = Collision.pointCylinderCollision(point, cylinder);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void silindirSilindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Cylinder cylinder1 = new Cylinder();
            Cylinder cylinder2 = new Cylinder();
            Random rnd = new Random();

            cylinder1.M.X = rnd.Next(150, 450);
            cylinder1.M.Y = rnd.Next(150, 350);
            cylinder1.M.Z = rnd.Next(50, 150);
            cylinder1.H = rnd.Next(50, 100);
            cylinder1.R = rnd.Next(50, 100);

            cylinder2.M.X = rnd.Next(150, 450);
            cylinder2.M.Y = rnd.Next(150, 350);
            cylinder2.M.Z = rnd.Next(50, 150);
            cylinder2.H = rnd.Next(50, 100);
            cylinder2.R = rnd.Next(50, 100);

            graphics.Clear(Color.White);
            graphics.DrawEllipse(pen, cylinder1.M.X, cylinder1.M.Y, cylinder1.R, cylinder1.R);
            graphics.DrawEllipse(pen, cylinder1.M.X, cylinder1.M.Y + cylinder1.H, cylinder1.R, cylinder1.R);
            graphics.DrawLine(pen, cylinder1.M.X, cylinder1.M.Y + cylinder1.R / 2, cylinder1.M.X, cylinder1.M.Y + cylinder1.H + cylinder1.R / 2);
            graphics.DrawLine(pen, cylinder1.M.X + cylinder1.R, cylinder1.M.Y + cylinder1.R / 2, cylinder1.M.X + cylinder1.R, cylinder1.M.Y + cylinder1.H + cylinder1.R / 2);

            graphics.DrawEllipse(pen, cylinder2.M.X, cylinder2.M.Y, cylinder2.R, cylinder2.R);
            graphics.DrawEllipse(pen, cylinder2.M.X, cylinder2.M.Y + cylinder2.H, cylinder2.R, cylinder2.R);
            graphics.DrawLine(pen, cylinder2.M.X, cylinder2.M.Y + cylinder2.R / 2, cylinder2.M.X, cylinder2.M.Y + cylinder2.H + cylinder2.R / 2);
            graphics.DrawLine(pen, cylinder2.M.X + cylinder2.R, cylinder2.M.Y + cylinder2.R / 2, cylinder2.M.X + cylinder2.R, cylinder2.M.Y + cylinder2.H + cylinder2.R / 2);

            bool sonuc = Collision.cylinderCylinderCollision(cylinder1, cylinder2);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void küreKüreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Sphere sphere1 = new Sphere();
            Sphere sphere2 = new Sphere();
            Random rnd = new Random();

            sphere1.M.X = rnd.Next(150, 550);
            sphere1.M.Y = rnd.Next(150, 350);
            sphere1.M.Z = rnd.Next(150, 350);
            sphere1.R = rnd.Next(50, 150);

            sphere2.M.X = rnd.Next(150, 550);
            sphere2.M.Y = rnd.Next(150, 350);
            sphere2.M.Z = sphere1.M.Z;
            sphere2.R = rnd.Next(50, 150);

            graphics.Clear(Color.White);
            graphics.DrawEllipse(pen, sphere1.M.X, sphere1.M.Y, sphere1.R, sphere1.R);
            graphics.DrawEllipse(pen, sphere1.M.X, sphere1.M.Y + (sphere1.R / 4), sphere1.R, (sphere1.R / 2));
            graphics.DrawEllipse(pen, sphere2.M.X, sphere2.M.Y, sphere2.R, sphere2.R);
            graphics.DrawEllipse(pen, sphere2.M.X, sphere2.M.Y + (sphere2.R / 4), sphere2.R, (sphere2.R / 2));

            bool sonuc = Collision.sphereSphereCollision(sphere1, sphere2);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }
        private void küreSilindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Sphere sphere = new Sphere();
            Cylinder cylinder = new Cylinder();
            Random rnd = new Random();

            sphere.M.X = rnd.Next(150, 550);
            sphere.M.Y = rnd.Next(150, 350);
            sphere.M.Z = rnd.Next(150, 350);
            sphere.R = rnd.Next(50, 150);

            cylinder.M.X = rnd.Next(150, 450);
            cylinder.M.Y = rnd.Next(150, 350);
            cylinder.M.Z = sphere.M.Z;
            cylinder.H = rnd.Next(50, 100);
            cylinder.R = rnd.Next(50, 100);

            graphics.Clear(Color.White);

            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y, sphere.R, sphere.R);
            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y + (sphere.R / 4), sphere.R, (sphere.R / 2));

            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y, cylinder.R, cylinder.R);
            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y + cylinder.H, cylinder.R, cylinder.R);
            graphics.DrawLine(pen, cylinder.M.X, cylinder.M.Y + cylinder.R / 2, cylinder.M.X, cylinder.M.Y + cylinder.H + cylinder.R / 2);
            graphics.DrawLine(pen, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.R / 2, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.H + cylinder.R / 2);

            bool sonuc = Collision.sphereCylinderCollision(sphere, cylinder);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void yüzeyKüreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Surface surface = new Surface();
            Sphere sphere = new Sphere();
            Random rnd = new Random();

            sphere.M.X = rnd.Next(150, 550);
            sphere.M.Y = rnd.Next(150, 350);
            sphere.M.Z = rnd.Next(150, 350);
            sphere.R = rnd.Next(50, 150);

            surface.M.X = rnd.Next(150, 550);
            surface.M.Y = rnd.Next(150, 350);
            surface.M.Z = rnd.Next(150, 350);
            surface.Depth = rnd.Next(50, 150);
            surface.Width = rnd.Next(50, 150);

            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, surface.M.X - (surface.Width / 2), surface.M.Y, surface.Width, 2);
            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y, sphere.R, sphere.R);
            graphics.DrawEllipse(pen, sphere.M.X, sphere.M.Y + (sphere.R / 4), sphere.R, (sphere.R / 2));

            bool sonuc = Collision.surfaceSphereCollision(surface, sphere);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void yüzeyDikdörtgenPrizmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Surface surface = new Surface();
            Prism prism = new Prism();
            Random rnd = new Random();

            surface.M.X = rnd.Next(150, 550);
            surface.M.Y = rnd.Next(150, 350);
            surface.M.Z = rnd.Next(150, 350);
            surface.Depth = rnd.Next(50, 150);
            surface.Width = rnd.Next(50, 150);

            prism.M.X = rnd.Next(150, 550);
            prism.M.Y = rnd.Next(150, 350);
            prism.M.Z = surface.M.Z;
            prism.Width = rnd.Next(50, 150);
            prism.Depth = rnd.Next(50, 150);
            prism.Height = rnd.Next(50, 150);

            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, surface.M.X - (surface.Width / 2), surface.M.Y, surface.Width, 2);
            graphics.DrawRectangle(pen, prism.M.X, prism.M.Y, prism.Width, prism.Height);
            //Üst yüzey
            graphics.DrawRectangle(pen, prism.M.X + prism.Depth, prism.M.Y + prism.Depth, prism.Width, prism.Height);
            //Yan yüzeyler
            graphics.DrawLine(pen, prism.M.X, prism.M.Y, prism.M.X + prism.Depth, prism.M.Y + prism.Depth);
            graphics.DrawLine(pen, prism.M.X + prism.Width, prism.M.Y, prism.M.X + prism.Width + prism.Depth, prism.M.Y + prism.Depth);
            graphics.DrawLine(pen, prism.M.X, prism.M.Y + prism.Height, prism.M.X + prism.Depth, prism.M.Y + prism.Height + prism.Depth);
            graphics.DrawLine(pen, prism.M.X + prism.Width, prism.M.Y + prism.Height, prism.M.X + prism.Width + prism.Depth, prism.M.Y + prism.Height + prism.Depth);

            bool sonuc = Collision.surfacePrismCollision(surface, prism);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void yüzeySilindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Surface surface = new Surface();
            Cylinder cylinder = new Cylinder();
            Random rnd = new Random();


            surface.M.X = rnd.Next(150, 550);
            surface.M.Y = rnd.Next(150, 350);
            surface.M.Z = rnd.Next(150, 350);
            surface.Depth = rnd.Next(50, 150);
            surface.Width = rnd.Next(50, 150);

            cylinder.M.X = rnd.Next(150, 450);
            cylinder.M.Y = rnd.Next(150, 350);
            cylinder.M.Z = surface.M.Z;
            cylinder.H = rnd.Next(50, 100);
            cylinder.R = rnd.Next(50, 100);

            graphics.Clear(Color.White);
            graphics.FillRectangle(brush, surface.M.X - (surface.Width / 2), surface.M.Y, surface.Width, 2);

            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y, cylinder.R, cylinder.R);
            graphics.DrawEllipse(pen, cylinder.M.X, cylinder.M.Y + cylinder.H, cylinder.R, cylinder.R);
            graphics.DrawLine(pen, cylinder.M.X, cylinder.M.Y + cylinder.R / 2, cylinder.M.X, cylinder.M.Y + cylinder.H + cylinder.R / 2);
            graphics.DrawLine(pen, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.R / 2, cylinder.M.X + cylinder.R, cylinder.M.Y + cylinder.H + cylinder.R / 2);

            bool sonuc = Collision.surfaceCylinderCollision(surface, cylinder);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }

        private void dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            Prism prism1 = new Prism();
            Prism prism2 = new Prism();
            Random rnd = new Random();

            prism2.M.X = rnd.Next(150, 450);
            prism2.M.Y = rnd.Next(200, 350);
            prism2.M.Z = rnd.Next(150, 350);
            prism2.Width = rnd.Next(50, 150);
            prism2.Depth = rnd.Next(50, 150);
            prism2.Height = rnd.Next(50, 150);

            prism1.M.X = rnd.Next(150, 450);
            prism1.M.Y = rnd.Next(200, 350);
            prism1.M.Z = prism2.M.Z;
            prism1.Width = rnd.Next(50, 150);
            prism1.Depth = rnd.Next(50, 150);
            prism1.Height = rnd.Next(50, 150);

            graphics.Clear(Color.White);
            graphics.DrawRectangle(pen, prism1.M.X, prism1.M.Y, prism1.Width, prism1.Height);
            graphics.DrawRectangle(pen, prism1.M.X + prism1.Depth, prism1.M.Y + prism1.Depth, prism1.Width, prism1.Height);
            graphics.DrawLine(pen, prism1.M.X, prism1.M.Y, prism1.M.X + prism1.Depth, prism1.M.Y + prism1.Depth);
            graphics.DrawLine(pen, prism1.M.X + prism1.Width, prism1.M.Y, prism1.M.X + prism1.Width + prism1.Depth, prism1.M.Y + prism1.Depth);
            graphics.DrawLine(pen, prism1.M.X, prism1.M.Y + prism1.Height, prism1.M.X + prism1.Depth, prism1.M.Y + prism1.Height + prism1.Depth);
            graphics.DrawLine(pen, prism1.M.X + prism1.Width, prism1.M.Y + prism1.Height, prism1.M.X + prism1.Width + prism1.Depth, prism1.M.Y + prism1.Height + prism1.Depth);

            graphics.DrawRectangle(pen, prism2.M.X, prism2.M.Y, prism2.Width, prism2.Height);
            graphics.DrawRectangle(pen, prism2.M.X + prism2.Depth, prism2.M.Y + prism2.Depth, prism2.Width, prism2.Height);
            graphics.DrawLine(pen, prism2.M.X, prism2.M.Y, prism2.M.X + prism2.Depth, prism2.M.Y + prism2.Depth);
            graphics.DrawLine(pen, prism2.M.X + prism2.Width, prism2.M.Y, prism2.M.X + prism2.Width + prism2.Depth, prism2.M.Y + prism2.Depth);
            graphics.DrawLine(pen, prism2.M.X, prism2.M.Y + prism2.Height, prism2.M.X + prism2.Depth, prism2.M.Y + prism2.Height + prism2.Depth);
            graphics.DrawLine(pen, prism2.M.X + prism2.Width, prism2.M.Y + prism2.Height, prism2.M.X + prism2.Width + prism2.Depth, prism2.M.Y + prism2.Height + prism2.Depth);


            bool sonuc = Collision.prismPrismCollision(prism1, prism2);
            if (sonuc == true)
            {
                textBox1.Text = "Çarpışma var";
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.Text = "Çarpışma yok";
                textBox1.BackColor = Color.IndianRed;
            }
        }
    }
}
