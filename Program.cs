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
            int x1 = random.Next(1, 11);
            int y1 = random.Next(1, 11);
            int x2 = random.Next(1, 11);
            int y2 = random.Next(1, 11);
            Console.WriteLine($"X1: {x1}, Y1: {y1}, X2: {x2}, Y2 {y2}");
        }
    }
}
