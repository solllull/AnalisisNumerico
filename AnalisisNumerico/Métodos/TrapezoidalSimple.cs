﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class TrapezoidalSimple
    {
        public static double f(double x)
        {
            //return Math.Log(1 + Math.Pow(x, 2)); Segunda integral
            //return (1 / (x + 0.5)) + ((1 / 4) * (Math.Pow(x, 2))); Primera integral
            //return (-1 / 16) * Math.Pow(x, 4) + (1 / 4) * Math.Pow(x, 3) - (3 / 4) * Math.Pow(x, 2) - x + 4; Ultima simplificada
            return (((-3 / 4) * Math.Pow(x, 2)) - x + 4) - (((1 / 16) * Math.Pow(x, 4)) - ((1 / 4) * Math.Pow(x, 3))); //Ultima no simplificada
        }

        public double Calcular(double a, double b)
        {
            return ((f(a) + f(b)) * (b - a)) / 2;
        }
    }
}
