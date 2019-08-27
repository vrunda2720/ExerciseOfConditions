using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition08
{
    class Program
    {
        static void Main(string[] args)
        {
           bool a1= PosNeg(-4, 5, true);
           Console.WriteLine("a1 is:" + a1);

           Console.ReadLine();
        }

        public static bool PosNeg(int a, int b, bool negative)
        {
            bool ispositive = false;

            if(negative==true)

            {
                if ((a < 0) && (b < 0))
                {
                    ispositive = true;
                }
            }
            else if(((a<0)&&(b>0))||((a>0)&&(b<0)))
            {
                ispositive = true;
            }

            return ispositive;
        }
    }
}
