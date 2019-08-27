using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition011
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1= FrontBack("code");
            Console.WriteLine("s1 is:" + s1);

            string s2 = FrontBack("a");
            Console.WriteLine("s2 is:" + s2);

            string s3 = FrontBack("ba");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string FrontBack(string str)
        {
            string first = str.Substring(0,1);
            string res1 = str.Replace(str[0], str[str.Length - 1]);
            string res2 = res1.Remove(str.Length - 1);
            string res3 = res2 + first;
            return res3;
            
        }
    }
}
