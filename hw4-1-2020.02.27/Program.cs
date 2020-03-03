using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_1_2020._02._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字:");
            int input = int.Parse(Console.ReadLine());
            List<int> _list = new List<int>();
            for (int i = 1; i<=input; i++)
            {
                _list.Add(i);
            }
            int sum = 0;
            sum = _list.FindAll((x) => x % 2 != 0).Sum()- _list.FindAll((x)=>x%2==0).Sum();
            //foreach (var item in _list)
            //{
            //    if (item != 1)
            //    {
            //        if (item % 2 == 0)
            //        {
            //            sum -= item; 
            //            //Console.Write($"+{item}");
            //        }
            //        else
            //        {
            //            sum += item; ;
            //            //Console.Write($"-{item}");
            //        }
            //    }
            //    else
            //    {
            //        sum += item;
            //        //Console.Write(item);
            //    }
            //}
            Console.WriteLine($"結果為{sum}");
            Console.ReadLine();
        }
    }
}
