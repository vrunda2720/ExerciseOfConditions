using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition022
{
    class Program
    {
        static void Main(string[] args)
        {
           string s1= StartOz("ozymandias");
            Console.WriteLine("s1 is:" + s1);

            string s2 = StartOz("bzoo");
            Console.WriteLine("s2 is:" + s2);

            string s3 = StartOz("oxx");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }

        public static string StartOz(string str)
        {
            string answer = str.Substring(0, 2);
            string first = str.Substring(0, 1);
            string second = str.Substring(1, 1);

            if(answer=="oz")
            {
                return answer;
            }

            else if (first=="o")
            {
                return first;
            }
            else if(second=="z")
            {
                return second;
            }


                return answer;
        }
    }
}
