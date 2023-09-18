using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsForQuadratic
{
    public static class Program
    {
        private const double Epslon = 1e-7;
        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            var roots = Solve(a, b, c);
        }

        public static double[] Solve(double a, double b, double c) 
        {
            if(Math.Abs(a) < Epslon)
            {
                return new double[0];
            }
            double D = b*b - 4 * a * c;
            if (Math.Abs(D) > Epslon)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                return new double[] { x1, x2 };
            }
            else if (Math.Abs(D) < -Epslon)
            {
                return new double[0];
            }
            else 
            {
                double x = -b / 2 * a;
                return new double[] { x, x };
            }
        }
    }
}
