using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberalsConversion
{
    internal class Program
    {
        private static Dictionary<char, int> Romans = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        static int convertRomanToInt(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && Romans[s[i]] < Romans[s[i + 1]])
                {
                    n -= Romans[s[i]];
                }
                else
                {
                    n += Romans[s[i]];
                }
            }
            return n;
        }

        static void Main(string[] args)
        {
            string s = "IVI";

            Console.WriteLine($"{s} = {convertRomanToInt(s)}");

            Console.ReadKey();

        }
    }
}
