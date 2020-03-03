using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_5_2020._02._27
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的整數數字字串:");
            //List<int> _list = Console.ReadLine().Split(',').Select(int.Parse).ToList();//select是看作業一寫出來的
            //var result = _list.OrderBy((x) => x).GroupBy((x) => x % 2 == 0);
            var result = Console.ReadLine()
                .Split(',')
                .Select((x) => int.Parse(x))
                .OrderBy((x) => x)
                .GroupBy((x) => x % 2)
                .Select((x) => (x.Key == 0 ? "偶數:":"奇數:")+ string.Join(",",x)) ;
            ////會先用Key分成0跟1兩群 _條件式_? true就執行前面 fales執行後面 最後再用string.Join加上逗號
            
            //.OrderByDescending((x)=>x.Key)
            //.Select((x) => $"{(x.Key == 0 ? "奇數":"偶數")}:{ string.Join(",",x)}") ;
            ////先用Key由大到小排 所以key排成1跟0 執行條件式+逗號
            
           //.Select((x) => (x.Key == 0 ? "除三餘0": x.Key==1 ? "除三餘1":"除三餘2")+ string.Join(",",x)) ;
           ////分除3的寫法


            //List<int> odd = _list.Where((x) => x % 2 == 0).OrderBy((x) => x).ToList();
            //List<int> even = _list.Where((x) => x % 2 != 0).OrderBy((x) => x).ToList();
            //Write("偶數:",odd);
            //Write("奇數:",even);
            foreach (var item in result)
            {
                Console.WriteLine(item);
                
            }
            Console.ReadLine();
        }
        static void Write (string s, List<int>list)
        {
            Console.Write(s);
            foreach(var item in list)
            {
                if (list.IndexOf(item) == 0)
                {
                    Console.Write($"{item}");
                }
                else
                {
                    Console.Write($",{item}");
                }
            }
            Console.WriteLine();
        }
    }
}
