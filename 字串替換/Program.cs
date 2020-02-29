using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class 字串替換
    {
        static void Main(string[] args)
        {

            var value = new Dictionary<char, string>();
            value.Add('1', "一");
            value.Add('2', "二");
            value.Add('3', "三");
            value.Add('4', "四");
            value.Add('5', "五");
            value.Add('6', "六");
            value.Add('7', "七");
            value.Add('8', "八");
            value.Add('9', "九");


            Console.Write("請輸入四位數數字 :");
            string input = Console.ReadLine();
            
            StringBuilder n = new StringBuilder();
            foreach(char m in input)
            {
                n.Append(value[m]);
            }
            Console.Write(n);
            Console.ReadLine();
        }

    }
}
