using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {

        static void Main(string[] args)
        {
            bool check=true;
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                check = Checker(input);
                Console.WriteLine(check);
            }
        }

        static bool Checker (string word)
        {
            char[] strary = word.ToArray();
            if (strary.Length==1)
            {
                return true;
            }

            for (int i = 0; i < strary.Length/2; i++)
            {
                if (strary[i]!=strary[strary.Length-i-1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
