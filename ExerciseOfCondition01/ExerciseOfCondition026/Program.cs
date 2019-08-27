using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition026
{
    class Program
    {
        static void Main(string[] args)
        {
           string s1= EndUp("Hello");
            Console.WriteLine("s1 is:" + s1);

            string s2 = EndUp("hi there");
            Console.WriteLine("s2 is:" + s2);

            string s3 = EndUp("hi");
            Console.WriteLine("s3 is:" + s3);
            Console.ReadLine();
        }
        public static string EndUp(string str)
        {
            if (str.Length >= 3)
            {
                string str2 = str.Substring(str.Length - 3);
                string str3 = str2.ToUpper();
                string str4 = str.Replace(str2, str3);
                return str4;

            }
            else
            {
                string str5 = str.ToUpper();
                return str5;
            }

        }       
            
    }
}
