using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingForFun
{
    class StringToIntegerATOI
    {
        static void Main(string[] args)
        {
            string word = "1234";
            int result = myAtoi(word);
            Console.Write(result);
            Console.Read();
        }
        static int myAtoi(string word)
        {
            int res = 0; // Initialize result

            // Iterate through all characters of input string and
            // update result
            for (int i = 0; i < word.Length && word[i] != '\0'; ++i)
            {
                 res = res * 10 + word[i] - '0';
            }
            return res;

            // return result.
        }
    }
}
