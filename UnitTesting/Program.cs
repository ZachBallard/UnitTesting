using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Bob();
            var againString = "";

            Console.WriteLine("I'd like to introduce you to Bob. He is a rather lackadaisical youth.");
            Console.WriteLine("\nYou can talk to him. Just don't expect it to be particularly productive.");

            while (true)
            {

                Console.WriteLine($"\nGo ahead and say something {againString}to Bob! > or type (exit) <");
                var remark = Console.ReadLine();

                if (remark == "exit")
                {
                    break;
                }

                bob.hey(remark);

                againString = "else ";
            }
        }
    }
}
