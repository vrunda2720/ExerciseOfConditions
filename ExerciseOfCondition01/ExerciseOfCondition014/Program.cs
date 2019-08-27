using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition014
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = Multiple3or5(3);
            Console.WriteLine("a1 is:" + a1);

            bool a2 = Multiple3or5(10);
            Console.WriteLine("a2 is:" + a2);

            bool a3 = Multiple3or5(8);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static bool Multiple3or5(int number)
        {
            bool ismultiple = false;
            if((number%3==0)||(number%5==0))
            {
                return true;
            }
            return ismultiple;
        }
    }
}
