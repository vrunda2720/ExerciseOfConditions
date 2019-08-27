using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition09
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = NotString("bnot candy");
            Console.WriteLine("s1 is:" + s1);
            Console.ReadLine();

        }

        public static string NotString(string s)
        {
            
            string answer = "";
            bool alreadyNot = false;

            var last3 = s.Substring(s.Length - 4, 4);
            Console.WriteLine(last3);



            if(s.Substring(0,3) == "not")
            {
                alreadyNot = true;
            }





            if(alreadyNot == true)
            {
                answer = s;
            }
            else {
                
            answer = "not " + s;
            }


            return answer;

          

        }
    }
}
