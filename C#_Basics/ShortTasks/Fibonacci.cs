using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    internal class Fibonacci
    {
        public long FibonacciSequence1(int n = 3)
        {
           
            return n == 0 ? 1 : n == 1 ? 2 : FibonacciSequence1(n - 1) + FibonacciSequence1(n - 2);
        }

        public long FibonacciSequence2(int n = 3)
        {
            return n == 0 ? 0 : n == 1? 1 : n == 2? 1 : FibonacciSequence2(n - 1) + FibonacciSequence2(n - 2);
        }

    }
}
