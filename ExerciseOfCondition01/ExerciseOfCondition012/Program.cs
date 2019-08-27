using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition012
{
    class Program
    {
        static void Main(string[] args)
        {
           string s1= Front3("Microsoft");
            Console.WriteLine("s1 is:" + s1);

            string s2 = Front3("Chocolate");
            Console.WriteLine("s2 is:" + s2);

            string s3 = Front3("at");
            Console.WriteLine("s3 is:" + s3);


            Console.ReadLine();
        }
        public static string Front3(string str)
        {
            //string result;
            if (str.Length >=3)
            {
                string first = str.Substring(0, 3);
                string res1 = string.Concat(Enumerable.Repeat(first, 3));
                return res1;
                
            }
            else
            {
                string res1 = string.Concat(Enumerable.Repeat(str, 3));
                return res1;
            }
         
            
        }
    }
}
