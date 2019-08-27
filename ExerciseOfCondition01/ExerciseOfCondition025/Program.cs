using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition025
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = GotE("Hello");
            Console.WriteLine("b1 is:" + b1);

            bool b2 = GotE("Heelle");
            Console.WriteLine("b2 is:" + b2);

            bool b3 = GotE("Heelele");
            Console.WriteLine("b3 is:" + b3);
            Console.ReadLine();
        }

        public static bool GotE(string str)
        {
            bool iscountE = false;
            var count = str.Count(s => s == 'e');
            if (count >= 1 && count <= 3)
            {
                iscountE = true;
                
            }

            return iscountE;
        }
    }
}
