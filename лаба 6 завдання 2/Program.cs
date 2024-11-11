using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6_завдання_2
{
    internal class Program
    {
        static double CalculateArcTg(double t, double p) {
            double k = Math.Sqrt(p+Math.Pow(t, 2));
            double x = p + k;
            double y = Math.Pow(Math.Atan(Math.Pow(x, 2)),3);
            return y;
            
                }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть p");
            double p = double.Parse(Console.ReadLine());
            double y = CalculateArcTg(t, p);
            Console.WriteLine($"Значення y = " + y);

        }
    }
}
