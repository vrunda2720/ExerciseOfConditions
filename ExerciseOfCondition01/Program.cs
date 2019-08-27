using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool output = AreWeInTrouble(false, false);
            Console.WriteLine("Result is  " + output);
            Console.ReadLine();
        }

        public static bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            bool isTrouble = false;

            if((aSmile == true & bSmile == true) || (aSmile == false & bSmile == false))
            {
                isTrouble = true;
            }


            return isTrouble;

        }
    }
}
