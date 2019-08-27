using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition03
{
    class Program
    {
        static void Main(string[] args)
        {
           int a1= SumDouble(2, 2);
            Console.WriteLine("a1 value:" + a1);

            int a2 = SumDouble(3, 2);
            Console.WriteLine("a2 value:" + a2);

            int a3 = SumDouble(1, 2);
            Console.WriteLine("a2 value:" + a3);
            Console.ReadLine();
        }

        public static int SumDouble(int a, int b)
        {

            int sum = a + b;

            if(a==b)
            {
                sum = 2*(a + b);
            }
            return sum;
        }
    }
}
