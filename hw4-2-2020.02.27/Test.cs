using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_2_2020._02._27
{
    class Test
    { 
        
        public string Write(string s)
        {
            string result = "是回文";
            List<char> _list = new List<char>();
            
            foreach (var item in s)
            {
                _list.Add(item);
            }
            for (int i = 0; i <= _list.Count()/2;i++)
            {
                
                if(_list[i]!= _list[_list.Count() - 1 - i])
                {
                    result = "不是回文";
                    break;
                }
            }
            return result;
        }
    }
}
