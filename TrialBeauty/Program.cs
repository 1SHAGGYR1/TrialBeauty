using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialBeauty
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Console.ReadLine();
            string s = Console.ReadLine();
            if ((s[0] == '?') || (s[s.Length - 1] == '?'))
                flag = true;
            for (int i = 1; (i < s.Length - 1); i++)
            {
                if (s[i] == '?')
                {
                    if ((s[i - 1] == s[i + 1]) || (s[i + 1] == '?'))
                        flag = true;
                }
                else
                    if ((s[i] == s[i + 1]) || (s[i] == s[i - 1]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            if (flag)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();  
        }
    }
}
