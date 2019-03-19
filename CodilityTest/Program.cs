using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = "hbbello";
            int[] occurrences = new int[26];
            foreach (char ch in S)
            {
                occurrences[(int)ch - 'a']++;
            }

            char best_char = 'a';
            int best_res = 0;

            //foreach(var item in occurrences)
            //{
            //    if((int)item > best_res)
            //    {

            //    }
            //}

            for (int i = 1; i < 26; i++)
            {
                if (occurrences[i] > best_res)
                {
                    best_char = (char)('a' + i);
                    best_res = occurrences[i];
                }
            }
            Console.WriteLine(best_char.ToString());

            //return best_char.ToString();
        }
    }
}
