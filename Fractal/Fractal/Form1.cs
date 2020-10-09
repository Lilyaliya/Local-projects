using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        public int iter;
        public Pen pen;
        public Graphics graphics;
        public int radius;
        public int k = 0;
        public int n = 0;
        public int interval = 0;
        public int iteration;
        public List<objectP> lines;
        public struct objectP
        {
            public Point a { get; set; }
            public Point b { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            Visual.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Timer_Tick()
        {
            //iteration += Timer.Interval; 
            //Timer.Interval *= 2;

            //iterator.Text = iter.ToString();

            iter--;
            interval++;
            //formGraphics.ScaleTransform((float)Math.Round(1 / Math.Pow(2, 0.5), 2), (float)Math.Round(1 / Math.Pow(2, 0.5), 2), System.Drawing.Drawing2D.MatrixOrder.Prepend);
            //formGraphics.TranslateTransform((float)Math.Round(Math.Pow(2, 0.5)), (float)Math.Round(Math.Pow(2, 0.5)));
            DrawPart(lines);
            
            //formGraphics.TranslateTransform(10,10);
        }

        public void DrawPart(List<objectP> lines)
        {
            List<objectP> linesGenerated = new List<objectP>();
            Point first = lines[lines.Count - 1].b;
            Console.WriteLine("Beginning from ({0})", first.X.ToString() + ", " + first.Y.ToString());
            //formGraphics.DrawLine(myPen, lines[lines.Count - 1].a, lines[lines.Count - 1].b);
            Point last = new Point();
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                int diapasonX = lines[i].b.X - first.X;
                int diapasonY = lines[i].b.Y - first.Y;
                //something
                if (lines[i].b.X > lines[i].a.X)
                {
                    k = 0; n = -1;
                    last = DrawPoint(lines[i].b, diapasonX, diapasonY);
                    Console.WriteLine("Drawing line from ({0}) into ({1}) on plan 1", first.X.ToString() + ", " + first.Y.ToString(), last.X.ToString() + ", " + last.Y.ToString());
                    formGraphics.DrawLine(myPen, first, last);
                }
                else if (lines[i].b.X < lines[i].a.X)
                {
                    k = 0; n = 1;
                    last = DrawPoint(lines[i].b, diapasonX, diapasonY);
                    Console.WriteLine("Drawing line from ({0}) into ({1}) on plan 3", first.X.ToString() + ", " + first.Y.ToString(), last.X.ToString() + ", " + last.Y.ToString());
                    formGraphics.DrawLine(myPen, first, last);
                }
                else if (lines[i].b.Y < lines[i].a.Y)
                {
                    k = 1; n = -1;
                    last = DrawPoint(lines[i].b, diapasonX, diapasonY);
                    Console.WriteLine("Drawing line from ({0}) into ({1}) on plan 2", first.X.ToString() + ", " + first.Y.ToString(), last.X.ToString() + ", " + last.Y.ToString());
                    formGraphics.DrawLine(myPen, first, last);
                }
                else if (lines[i].b.Y > lines[i].a.Y)
                {
                    k = 1; n = 1;
                    last = DrawPoint(lines[i].b, diapasonX, diapasonY);
                    Console.WriteLine("Drawing line from ({0}) into ({1}) on plan 4", first.X.ToString() + ", " + first.Y.ToString(), last.X.ToString() + ", " + last.Y.ToString());
                    formGraphics.DrawLine(myPen, first, last);
                }
               // Visual.Update();
                
                linesGenerated.Add(new objectP { a = first, b = last });
                first = last;
            }

            foreach (var element in linesGenerated)
                lines.Add(element);
        }
        //current is b то есть конечная точка
        Point DrawPoint(Point current, int dX, int dY)
        {
            var x = Math.Cos(n * Math.PI / 2 + Math.PI / 2 * k) * radius;
            var y = Math.Sin(n * Math.PI / 2 + Math.PI / 2 * k) * radius;
            return new Point(current.X - (int)x - dX, current.Y + (int)y - dY);
        }

        Pen myPen;
        Brush brush = new SolidBrush(Color.Black);
        Graphics formGraphics;
        //Image im;
        public void Form1_Load(object sender, EventArgs e)
        {
            Visual.Enabled = true;
            Visual.SizeMode = PictureBoxSizeMode.StretchImage;
            myPen = new Pen(brush, 1);
            //im = new Bitmap(Visual.Width, Visual.Height);
            //Visual.Image = im;
            //formGraphics = Graphics.FromImage(Visual.Image);
           // Bitmap bitmap = new Bitmap(Visual.Width, Visual.Height, formGraphics);
            //Visual.Image = bitmap;
            formGraphics = Visual.CreateGraphics();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            DrawFractal.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            formGraphics.Clear(Color.White);
            radius = Convert.ToInt32(textBox2.Text);
            lines = new List<objectP>() { new objectP { a = new Point((int)(Visual.Width/2), (int)(Visual.Height / 2)), b = new Point(radius + (int)(Visual.Width /2), (int)(Visual.Height / 2)) } };
            //iterator.Text = textBox1.Text;
            
            iter = Convert.ToInt32(textBox1.Text);
            formGraphics.DrawLine(myPen, lines[lines.Count - 1].a, lines[lines.Count - 1].b);
            Timer.Interval = 500;
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //iteration += Timer.Interval; 
            //Timer.Interval *= 2;
            iter--;
            interval++;
            //iterator.Text = iter.ToString();
            if (iter == 0)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                DrawFractal.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                Timer.Enabled = false;
            }
            //Timer.Interval = 100;
            //Timer.Enabled = true;
            
            //formGraphics.ScaleTransform((float)Math.Round(1 / Math.Pow(2, 0.5), 2), (float)Math.Round(1 / Math.Pow(2, 0.5), 2), System.Drawing.Drawing2D.MatrixOrder.Prepend);
            //formGraphics.TranslateTransform((float)Math.Round(Math.Pow(2, 0.5)), (float)Math.Round(Math.Pow(2, 0.5)));
            DrawPart(lines);

            //formGraphics.TranslateTransform(10,10);
        }
    }
}
