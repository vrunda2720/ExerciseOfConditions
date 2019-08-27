using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition04
{
    class Program
    {
        static void Main(string[] args)
        {
           int a1= Diff21(23);
           Console.WriteLine("a1 is:" + a1);

            int a2 = Diff21(10);
            Console.WriteLine("a2 is:" + a2);

            int a3 = Diff21(21);
            Console.WriteLine("a3 is:" + a3);
            Console.ReadLine();
        }
        public static int Diff21(int n)
        {
            int answer;

            if(n>21)
            {
                answer = 2*(n-21);
            }
            else
            {
                answer = 21-n;
            }

            return answer;
        }
    }
}
