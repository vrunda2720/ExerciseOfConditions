using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition016
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = IcyHot(120, -1);
            Console.WriteLine("a1 is:" + a1);

            bool a2 = IcyHot( -1,120);
            Console.WriteLine("a2 is:" + a2);

            bool a3 = IcyHot(2,120);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static bool IcyHot(int temp1, int temp2)
        {
            bool ishot = false;

            if(((temp1<0)&&(temp2>100))||((temp1>100)&&(temp2<0)))
            {
                ishot = true;
            }

            return ishot;
        }
    }
}
