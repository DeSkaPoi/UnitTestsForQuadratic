public class Program
{
    private const double Epslon = 1e-7;
    private static void Main(string[] args)
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
        if (Math.Abs(a) <= Epslon)
        {
            throw new Exception("a = 0");
        }
        double D = b * b - 4 * a * c;
        if (D > 0 && Math.Abs(D) > Epslon)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
            return new double[] { x1, x2 };
        }
        else if (D <= -Epslon && D < 0)
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