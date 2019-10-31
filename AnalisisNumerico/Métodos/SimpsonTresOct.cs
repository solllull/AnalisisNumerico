﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class SimpsonTresOct
    {
        public static double f(double x)
        {
            return (Math.Pow(Math.E, x)) * (1 - Math.Pow(0.5, 2));
        }

        public double Calcular(double a, double b)
        {
            double h;
            h = (b - a) / 3;
            return ((3 * h) / 8) * (f(a) + 3 * f(h) + 3 * f(2 * h) + f(b));
        }
    }
}
