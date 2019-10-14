using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一段字符:");
            string str = Convert.ToString(Console.ReadLine());
            To_Str to = new To_Str();
            Console.WriteLine("提取的整数为:");
            to.To_str(str);
        }
    }
    public class To_Str
    {
        public void To_str(string s)
        {
            int w;
            for (int i = 0; i < s.Length; i++)
            {
                w = 0;
                if (s[i] >= '0' && s[i] <= '9')
                {
                    w *= 10;
                    w += s[i] - '0';
                    if (i == s.Length - 1)
                        Console.WriteLine(w); 
                    else
                    {
                        for (int j = i + 1; j < s.Length; j++)
                        {
                            if (s[j] >= '0' && s[j] <= '9')
                            {
                                w *= 10;
                                w += s[j] - '0';
                                continue;
                            }
                            else
                                Console.WriteLine(w);
                            i = j;
                            break;
                        }
                    }
                }
                else
                    continue;
            }


        }
    }
}
