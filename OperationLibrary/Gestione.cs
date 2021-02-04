using System;

namespace OperationLibrary
{
    public class Gestione
    {
        public static int Somma(int a, int b)
        {
            return a + b;
        }
        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }
        public static double Divisione(double a, double b)
        {
            double divisione;
            if (b == 0)
            {
               divisione = double.NaN;
            }
            else
            {
                divisione = a / b;
            }
            return divisione;
        }
    }
}
