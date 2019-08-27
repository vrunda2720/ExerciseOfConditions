using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOfCondition015
{
    class Program
    {
        static void Main(string[] args)
        {
           bool a1= StartHi("hithere");
            Console.WriteLine("a1 is:" + a1);
            Console.ReadLine();
        }
        public static bool StartHi(string str)
        {
            bool isHi = false;
           // string[] result = str.Split(' ');
            string first = str.Substring(0, 2);

            if((str==first)&&(str[2]==' '))
            {
                isHi = true;
            }

            return isHi;
        }
    }
}
