using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition018
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool b1 = HasTeen(13, 20, 10);
            //Console.WriteLine("b1 is:" + b1);

            //bool b2 = HasTeen(20, 19, 10);
            //Console.WriteLine("b2 is:" + b2);

            bool b3 = HasTeen(20, 10, 12);
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }

        public static bool HasTeen(int a, int b, int c)
        {
            bool isTeen = false;
            IEnumerable<int> Teen = Enumerable.Range(13, 7);

            if ((Teen.Contains(a))|| (Teen.Contains(b))|| (Teen.Contains(c)))
            {
                isTeen = true;
            }

            


                return isTeen;
        }
    }
}
