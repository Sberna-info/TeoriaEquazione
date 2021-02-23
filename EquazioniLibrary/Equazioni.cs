using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            return a != 0;
        }

        public static bool IsInconsisted(double a, double b)
        {
            return (a == 0 && b == 0);
        }

        public static bool IsDegree2(double a)
        {
            return a != 0;
        }

        public static double Delta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        public static string Equazione(int a, int b, int c)
        {
            double delta = Delta(a, b, c);
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            if (a == 0)
                return $"x - {x1}";
            else if (delta < 0)
                return "Impossibile";

            return $"x1 - {x1} x2 - {x2}";
        }

        public static string EquationDegree1(double a, double b) 
        {
            if(IsDetermined(a))
            {
                double x = b / a;
                return $"x - {x}";
            }
            else if(IsInconsisted(a,  b))
            {
                return "Impossibile";
            }
            return "indeterminata";
        }
    }
}
