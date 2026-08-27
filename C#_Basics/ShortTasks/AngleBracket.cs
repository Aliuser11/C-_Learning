using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    public interface IAngleBracktes
    {
        List<string> PlaceAngleBrackets(int n = 5);
    }
    internal class AngleBracket : IAngleBracktes
    {
        //private readonly int n = 1;
        public List<string> PlaceAngleBrackets(int n = 5)
        {
            var list = new List<string>();
            AddBrackets(n, 0, 0, "", list);
            return list;
        }

        private void AddBrackets(int n, int op, int cl, string seq, List<string> list)
        {
            var left = "<";
            var right = ">";
            if (seq.Length == 2 * n)
            { 
                list.Add(seq);
            }
            if (op < n)
            {
                AddBrackets(n, op + 1, cl, seq + left, list);
            }
            if (cl < op)
            {
                AddBrackets(n, op, cl + 1, seq + right, list);
            }
        }
    }
}
