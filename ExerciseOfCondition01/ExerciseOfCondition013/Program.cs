using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition013
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = BackAround("cat");
            Console.WriteLine("s1 is:" + s1);

            string s2 = BackAround("Hello");
            Console.WriteLine("s2 is:" + s2);

            string s3 = BackAround("a");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string BackAround(string str)
        {
            string Last = str.Substring(str.Length-1);
            string result = str.Insert(0, Last);
            string result2 = result+Last;
            return result2;
        }
    }
}
