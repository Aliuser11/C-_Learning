using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    internal class LexicographicalPhone
    {
        //private static readonly Dictionary<char, string> dictionary = new()
        //{
        //    { '0', "0" },
        //    { '1', "1" },
        //    { '2', "abc" },
        //    { '3', "def" },
        //    { '4', "ghi" },
        //    { '5', "jkl" },
        //    { '6', "mno" },
        //    { '7', "pqrs" },
        //    { '8', "tuv" },
        //    { '9', "wxyz" }
        //};
        private readonly string digits = "23"; // 2 to 2 bo index od zera w zerze

        public List<string> DigitCombination()
        {
            Dictionary<char, string> dictionary = new()
            {
                ['0'] = "0",
                ['1'] = "1",
                ['2'] = "abc",
                ['3'] = "def",
                ['4'] = "ghi",
                ['5'] = "jkl",
                ['6'] = "mno",
                ['7'] = "pqrs",
                ['8'] = "tuv",
                ['9'] = "wxyz"
            };

            var res = new List<string>();

            if (string.IsNullOrEmpty(digits))
                return res;
            Lex(0, digits, res, new char[digits.Length]);
            return res;


            void Lex(int index, string digits, List<string> result,char[] example)
            {
                var yyy = dictionary[digits[index]];
                if (index == digits.Length) { res.Add(new string(example)); }
                foreach (var x in yyy)
                {
                    example[index] = x;
                    Lex(index + 1, digits, result, example);
                }
            }

           
        }

        private static readonly Dictionary<char, string> Map = new()
        {
            { '0', "0" },
            { '1', "1" },
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public IList<string> DigitCombination1()
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;

            Backtrack(0, new char[digits.Length], digits, result);
            return result;
        }

        private void Backtrack(int index, char[] current, string digits, List<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(new string(current));
                return;
            }

            string letters = Map[digits[index]];
            foreach (char c in letters)      // already in lexicographic order
            {
                current[index] = c;
                Backtrack(index + 1, current, digits, result);
            }
        }
    } 
}
