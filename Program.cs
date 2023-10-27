using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double x1 = random.Next(1, 11);
            double y1 = random.Next(1, 11);
            double x2 = random.Next(1, 11);
            double y2 = random.Next(1, 11);
            Console.WriteLine($"X1: {x1}, Y1: {y1}, X2: {x2}, Y2 {y2}");

            double rast = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine(rast.ToString());
            Console.ReadKey();
        }
    }
}
