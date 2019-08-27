using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition010
{
    class Program
    {
        static void Main(string[] args)
        {
           string s1= MissingChar("kitten", 1);
           Console.WriteLine("s1 is:" + s1);

            string s2 = MissingChar("kitten", 0);
            Console.WriteLine("s2 is:" + s2);

            string s3 = MissingChar("kitten", 4);
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string MissingChar(string str, int n)
        {

            str = str.Remove(n,1);
            return str;
        }
    }
}
