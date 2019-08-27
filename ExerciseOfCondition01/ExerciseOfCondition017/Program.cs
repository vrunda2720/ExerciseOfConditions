using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition017
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = Between10and20(12, 99);
            Console.WriteLine("a1 is:" + a1);

            bool a2 = Between10and20(21,12);
            Console.WriteLine("a2 is:" + a2);

            bool a3 = Between10and20(8,99);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static bool Between10and20(int a, int b)
        {
            bool is10and20 = false;

            if ((Enumerable.Range(10, 20).Contains(a))|| (Enumerable.Range(10, 20).Contains(b)))
            {
                is10and20 = true;
            }
                //true

                return is10and20;
        }
    }
}
