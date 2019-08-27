using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = CanSleepIn(false, false);
            Console.WriteLine("a1  value:" + a1);

            bool a2= CanSleepIn(true, false);
            Console.WriteLine("a2  value:" + a2);

            bool a3= CanSleepIn(false, true);
            Console.WriteLine("a3  value:" + a3);
            Console.ReadLine();

        }


        public static bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool isSleep = false;

            if((isWeekday=false)||(isVacation=true))
                {
                isSleep = true;
            }
            

            return isSleep;
        }
    }
}
