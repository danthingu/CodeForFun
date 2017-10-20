using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToRoman
{
    class IntegerToRoman
    {
        static void Main(string[] args)
        {
            Console.Write(ConvertIntToRoman(3999));
            Console.Read();
        }

        static string ConvertIntToRoman(int number)
        {
            string result;
            var M = new string[] { "", "M", "MM", "MMM" };
            var C = new string[]{ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var X = new string[]{ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var I =new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[number / 1000] + C[(number % 1000) / 100] + X[((number % 1000) % 100) / 10] + I[(((number % 1000) % 100) % 10)];
        }
    }
}
