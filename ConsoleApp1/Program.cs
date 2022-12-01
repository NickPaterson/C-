using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");

            bool isTrue = true;

            string isTrueStr = isTrue.ToString();

            for (int i = 0; i < 4; i++)
            {
                char x = isTrueStr[i];
                Console.WriteLine(x);
            }

            Console.ReadLine();
            Console.WriteLine("Testing push");

        }
    }
}
