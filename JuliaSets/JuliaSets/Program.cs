using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuliaSets
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Func<Complex, Complex> func = (Complex x) =>  Complex.Cos(x) + 0.3f;

            Func<Complex, Complex> func2 = (Complex x) => Complex.Pow(x, 4) + new Complex(0.25, 0.25);
            Application.Run(new Form1(2, func2));
            
        }
    }
}
