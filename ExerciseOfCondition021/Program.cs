using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition021
{
    class Program
    {
        static void Main(string[] args)
        {
          bool a1=  IxStart("mix snacks");
          Console.WriteLine("a1 is:" + a1);

          bool a2 = IxStart("pix snacks");
          Console.WriteLine("a2 is:" + a2);

          bool a3 = IxStart("piz snacks");
          Console.WriteLine("a3 is:" + a3);

            Console.ReadLine();
        }

        public static bool IxStart(string str)
        {
            bool isIx = false;

            string first = str.Substring(1, 2);

            if(first=="ix")
            {
                isIx = true;
            }

            return isIx;
        }
    }
}
