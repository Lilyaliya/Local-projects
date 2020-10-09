using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace GosperCurve
{
    public partial class Form1 : Form
    {
        public int iteration;
        public float size = 10;
        public Form1()
        {
            InitializeComponent();
        }

        public void A(int iter, float size)// {\displaystyle A\mapsto A-B--B+A++AA+B-}
        {
            size /= (float)Math.Sqrt(7);
            Turtle.PenSize /= (float)Math.Sqrt(7);
            iter--;
            if (iter>0)
            {
                A(iter,size);
                Turtle.Rotate(60);
                B(iter,size);
                Turtle.Rotate(60);
                Turtle.Rotate(60);
                B(iter,size);
                Turtle.Rotate(300);
                A(iter,size);
                Turtle.Rotate(300);
                Turtle.Rotate(300);
                A(iter,size);
                A(iter, size);
                Turtle.Rotate(300);
                B(iter, size);
                Turtle.Rotate(60);
            }
            else
            {
                Turtle.Forward(size);
                Turtle.Rotate(60);
                Turtle.Forward(size);
                Turtle.Rotate(60);
                Turtle.Rotate(60);
                Turtle.Forward(size);
                Turtle.Rotate(300);
                Turtle.Forward(size);
                Turtle.Rotate(300);
                Turtle.Rotate(300);
                Turtle.Forward(size);
                Turtle.Forward(size);
                Turtle.Rotate(300);
                Turtle.Forward(size);
                Turtle.Rotate(60);

            }
        }

        public void B(int iter, float size)// {\displaystyle B\mapsto +A-BB--B-A++A+B}
        {
            size /= (float)Math.Sqrt(7);
            iter--;
            Turtle.PenSize /= (float)Math.Sqrt(7);
            if (iter > 0)
            {
                Turtle.Rotate(300);
                A(iter, size);
                Turtle.Rotate(60);
                B(iter, size);
                B(iter, size);
                Turtle.Rotate(60);
                Turtle.Rotate(60);
                B(iter, size);
                Turtle.Rotate(60);
                A(iter, size);
                Turtle.Rotate(300);
                Turtle.Rotate(300);
                A(iter, size);
                Turtle.Rotate(300);
                B(iter, size);
            }
            else
            {
                Turtle.Rotate(300);
                Turtle.Forward(size);
                Turtle.Rotate(60);
                Turtle.Forward(size);
                Turtle.Forward(size);
                Turtle.Rotate(60);
                Turtle.Rotate(60);
                Turtle.Forward(size);
                Turtle.Rotate(60);
                Turtle.Forward(size);
                Turtle.Rotate(300);
                Turtle.Rotate(300);
                Turtle.Forward(size);
                Turtle.Rotate(300);
                Turtle.Forward(size);
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenColor = Color.Black;
            Turtle.PenSize = 10;
            if (this.IterationNum.Text!=null)
            {
                iteration = Convert.ToInt32(IterationNum.Text);
                A(iteration, 250);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            //size = 100;
        }
    }
}
