using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition05
{
    class Program
    {
        static void Main(string[] args)
        {
           bool a1= ParrotTrouble(true, 6);
           Console.WriteLine("a1 is:" + a1);

            bool a2 = ParrotTrouble(true, 7);
            Console.WriteLine("a2 is:" + a2);

            bool a3 = ParrotTrouble(false, 6);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            bool isTrouble = false;

            if((isTalking==true)&&(hour<7)||(hour>20))
            {
                isTrouble= true;
            }

            return isTrouble;
        }
    }
}
