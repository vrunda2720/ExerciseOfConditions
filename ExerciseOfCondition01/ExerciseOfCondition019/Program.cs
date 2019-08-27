using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition019
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = SoAlone(13, 13);
            Console.WriteLine("b1 is:" + b1);
            Console.ReadLine();
        }
        public static bool SoAlone(int a, int b)
        {
            bool isAlone = false;
            IEnumerable<int> Teen = Enumerable.Range(13, 7);

            if (a==b )
            {
                isAlone = false;
            }
            else if ((Teen.Contains(a)) || (Teen.Contains(b)))
            {
                isAlone = true;
            }
            
            return isAlone;
        }
    }
}
