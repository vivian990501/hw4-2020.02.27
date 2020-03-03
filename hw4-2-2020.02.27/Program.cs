using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_2_2020._02._27
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var input_class = new Test();
            //ViolenceWrite(input);
            string result = input_class.Write(input);
            Console.WriteLine(input+result);
            Console.ReadLine();
        }


        static void ViolenceWrite( string input)
        {
            string input_z = string.Empty;
            for (int i = input.Count() - 1; i >= 0; i--)
            {
                input_z += input[i];
            }
            //Console.WriteLine(input_z);
            if (input_z == input)
            {
                Console.WriteLine($"{input} 是回文");
            }
            else
            {
                Console.WriteLine($"{input} 不是回文");
            }

        }
    }
}
