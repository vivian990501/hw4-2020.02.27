 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_3_2020._02._28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            string[] one   = new string[] { " _ ", "   ", " _ ", " _ ", "   ", " _ ", " _ ", " _ ", " _ ", " _ " };
            string[] two   = new string[] { "| |", "  |", " _|", " _|", "|_|", "|_ ", "|_ ", "  |", "|_|", "|_|" };
            string[] three = new string[] { "|_|", "  |", "|_ ", " _|", "  |", " _|", "|_|", "  |", "|_|", " _|" };
            string input = Console.ReadLine();

            foreach (var i in input)
            {
                Console.Write(one[i-48]);
            }
            Console.WriteLine();
            foreach (var i in input)
            {
                Console.Write(two[i - 48]);
            }
            Console.WriteLine();
            foreach (var i in input)
            {
                Console.Write(three[i - 48]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
        //static void Write(string s)
        //{


        //}
    }
}
