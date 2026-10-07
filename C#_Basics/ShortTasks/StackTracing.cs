using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{

    internal class StackTracing 
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public StackTracing()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();

            int n = 10;
            string[] operations = { "push 2", "push 0", "push 3", "push 0", "getMin", "pop", "getMin", "pop", "top", "getMin" };
            
            foreach (var op in operations)
            {
                string[] parts = op.Split(' ');
                switch (parts[0])
                {
                    case "push":
                        int val = int.Parse(parts[1]);
                        Push(val);
                        break;
                    case "pop":
                        Pop();
                        break;
                    case "top":
                        var x = Top();
                        Console.WriteLine(x);
                        break;
                    case "getMin":
                        var y = GetMin();
                        Console.WriteLine(y);
                        break;
                }
            }
        }

        public void Push(int val)
        {
            stack.Push(val);
            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
            else { minStack.Push(minStack.Peek()); }
        }

        public void Pop()
        {
            if (stack.Count == 0) return;
            int val = stack.Pop();
            if (val == minStack.Peek())
            {
                minStack.Pop();
            }
        }

        public int Top()
        {
            if (stack.Count == 0) return -1;
            return stack.Peek();
        }

        public int GetMin()
        {
            if (minStack.Count == 0) return -1;
            return minStack.Peek();
        }
    }
}
