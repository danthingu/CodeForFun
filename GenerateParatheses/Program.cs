using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
    // unresolved
    class Program
    {
        static void Main(string[] args)
        {
            var output = GenerateParenthesis(3);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<String> list = new List<string>();
            backtrack(list, "", 0, 0, n);
            return list;
        }
        public static void backtrack(List<String> list, String str, int open, int close, int max)
        {

            if (str.Length == max * 2)
            {

                list.Add(str);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                return;
            }
            Console.WriteLine($"Outside ===> Open: {open}, Close: {close}");
            if (open < max)
            {
                Console.WriteLine($"Open < Max ==> Open: {open}, Close: {close}");
                backtrack(list, str + "(", open + 1, close, max);
            }
            if (close < open)
            {
                Console.WriteLine($"Close < Open ==> Open: {open}, Close: {close}");
                backtrack(list, str + ")", open, close + 1, max);
            }
        }
    }
}
