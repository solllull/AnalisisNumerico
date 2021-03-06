﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class RegresiónLineal
    {
        public double a1 { get; set; }
        public double a0 { get; set; }
        public double St { get; set; }
        public double Sr { get; set; }
        public double SumX { get; set; }
        public double SumY { get; set; }
        public double SumXY { get; set; }
        public double SumX2 { get; set; }
        public int n { get; set; } // Cantidad de puntos ingresados
        public double r { get; set; } // Coeficiente de correlación

        public RegresiónLineal()
        {
            SumX = 0;
            SumY = 0;
            SumXY = 0;
            SumX2 = 0;
            Sr = 0;
            St = 0;
        }

        public A1A0 Calcular(double[,] Matriz, double tolerancia)
        {
            A1A0 resultado = new A1A0();
            resultado.a1 = (n*SumXY - SumX*SumY) / (n*SumX2 - Math.Pow(SumX,2));
            a1 = resultado.a1;
            resultado.a0 = (SumY / n) - (a1 * (SumX / n));
            a0 = resultado.a0;

            for (int i = 0; i < n-1; i++)
            {
                Sr = Sr + Math.Pow((a1 * Matriz[i, 0]) + a0 - Matriz[i, 1], 2);
                St = St + Math.Pow((SumY / n) - Matriz[i, 1], 2);
            }

            resultado.r = Math.Sqrt((St - Sr) / St) * 100;

            if (resultado.r < tolerancia)
                resultado.Eficacia = "No es aceptable el ajuste";
            else
                resultado.Eficacia = "Consideramos que el ajuste es aceptable";

            return resultado; //contiene a1, a0, coeficiente de correlacion y comentario.
        }
    }
}
