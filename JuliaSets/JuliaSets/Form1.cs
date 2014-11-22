using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuliaSets
{
    public partial class Form1 : Form
    {
        private double size; // ?
        private Func<Complex, Complex> testFunc;

        public Form1(double size, Func<Complex, Complex> func)
        {
            this.size = size;
            this.testFunc = func;
            InitializeComponent();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var delta = 1e-2;
            for (double x = -size; x < size; x += delta)
                for (double y = -size; y < size; y += delta)
                {
                    int color = Calculator.Calculate(testFunc, new Complex(x, y), 100);

                    graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(color, color, color, 255))), Resize(x), Resize(y), 1, 1);
                }
        }

        private float Resize(double x)
        {
            return (float)((x + size)*Width/(2*size));
        }
    }
}
