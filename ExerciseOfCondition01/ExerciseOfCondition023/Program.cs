using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition023
{
    class Program
    {
        static void Main(string[] args)
        {
           int i1= Max(1, 2, 3);
           Console.WriteLine("i1 is:" + i1);

           int i2 = Max(1, 3, 2);
           Console.WriteLine("i2 is:" + i2);

           int i3 = Max(3, 2, 1);
           Console.WriteLine("i3 is:" + i3);
            Console.ReadLine();

        }

        public static int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
    }
}
