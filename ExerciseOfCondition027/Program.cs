using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition027
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = EveryNth("abcdefg", 3);
            Console.WriteLine("s1 is:" + s1);
            Console.ReadLine();
        }
        public static string EveryNth(string str, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i =0; i < str.Length; i++)
            {
                if(i % n == 0)
                {
                    sb.Append(str[i]);
                }

            }
            
            return sb.ToString();
        }
    }
}
