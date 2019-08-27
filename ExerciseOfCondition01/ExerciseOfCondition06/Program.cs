using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition06
{
    class Program
    {
        static void Main(string[] args)
        {
           bool a1= Makes10(9, 10);
           Console.WriteLine("a1 is:" + a1);

            bool a2 = Makes10(9, 9);
            Console.WriteLine("a2 is:" + a2);

            bool a3 = Makes10(1, 9);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static bool Makes10(int a, int b)
        {
            bool is10 = false;

            if((a==10)||(b==10)||(a+b==10))
            {
                is10 = true;
            }

            return is10;
        }
    }
}
