using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition020
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = RemoveDel("adelbc");
            Console.WriteLine("s1 is:" + s1);

            string s2 = RemoveDel("adelHello");
            Console.WriteLine("s2 is:" + s2);

            string s3 = RemoveDel("adedbc");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string RemoveDel(string str)
        {
            string first = str.Substring(1, 3);

            if (first=="del")
            {
                str = str.Remove(1,3);

            }
            return str;
        }
    }
}
