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
            return (b * b) - (4 * a * c);
        }

        public static string EquazioneSecondo(int a, int b, int c)
        {
            double x1 = 0;
            double x2;
            double delta = Delta(a, b, c);
            if (delta == 0)
                return $"x = {x1}";
            else if (delta < 0)
                return "l'equazione è Impossibile";
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return $"x1 = {x1} x2 = {x2}";
            }
        }

        public static string EquationDegree1(double a, double b) 
        {
            if(IsDetermined(a))
            {
                double x = b / a;
                return $"x = {x}";
            }
            else if(IsInconsisted(a,  b))
            {
                return "l'equazione è Impossibile";
            }
            return "l'equazione è indeterminata";
        }
    }
}
