using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition024
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Closer(8, 11);
            Console.WriteLine("a1 is:" + a1);
            Console.ReadLine();
        }

        public static int Closer(int a, int b)
        {
            int A = a - 10;
            int B = b - 10;

            //if (Math.Abs(A) == Math.Abs(B))
            //{
            //    return 0;
            //}
            //if (Math.Abs(A) < Math.Abs(B))
            //{
            //    return a;
            //}
            //if (Math.Abs(A) > Math.Abs(B))
            //{
            //    return b;
            //}
            //return 0;
            int calcA = Math.Abs(a - 10);
            int calcB = Math.Abs(b - 10);

            if (calcA == calcB)
            {
                return 0;
            }

            if (calcA < calcB)
            {
                return a;
            }

            return b;
        }
    }
}
