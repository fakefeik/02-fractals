using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace JuliaSets
{
    public class Calculator
    {
        //public static bool Calculate(Func<Complex, Complex> testFunc, Complex firstComplex, int iterations)
        //{
        //    var complex = firstComplex;
        //    for (int i = 0; i < iterations; i++)
        //    {
        //        complex = testFunc(complex);
        //        if (complex.Magnitude > 2)
        //            return true;
        //    }
        //    return false;
        //}

        public static int Calculate(Func<Complex, Complex> testFunc, Complex firstComplex, int iterations)
        {
            var complex = firstComplex;
            for (int i = 0; i < iterations; i++)
            {
                complex = testFunc(complex);
                if (complex.Magnitude > 2)
                    return i;
            }
            return 0;
        }

        public static bool Calculate(Complex firstComplex, int iterations)
        {
            var complex = firstComplex;
            for (int i = 0; i < iterations; i++)
            {
                complex = complex*complex + firstComplex;
                if (complex.Magnitude > 2)
                    return true;

            }
            return false;
        } 
    }
}
