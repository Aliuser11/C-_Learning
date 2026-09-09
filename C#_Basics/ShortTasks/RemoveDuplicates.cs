using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    public interface IRemoveDuplicates
    {
        List<int> NoDuplicates();
        int RemoveElements(int k = 3);
        //LinkedListNode<int> NoDuplicatesInListNode();
    }

    internal class RemoveDuplicates : IRemoveDuplicates
    {
        private readonly List<int> head1 = [1, 2, 2, 2, 3, 4, 4, 5];
        private readonly List<int> timestamps = [1, 2, 3, 8, 10];

        public List<int> NoDuplicates()
        {
            var distinct = head1.ToHashSet();
            return distinct.ToList();
        }

        public int RemoveElements(int k = 3)
        {
            if (timestamps.Count == 0) return 0;
            var neList = new List<int>();

            var first = timestamps[0];

            var counter = 1;
            for (int i = 1; i < timestamps.Count; i++)
            {
                var odej = timestamps[i] - first;
                if (odej >= k)
                {
                    counter++;
                    //timestamps[counter++] = timestamps[i];
                    first = timestamps[i];
                }
            }
            return counter;
        }

        //public LinkedListNode<int> NoDuplicatesInListNode()
        //{
        //    LinkedListNode<int> head = [1, 2, 2, 2, 3, 4, 4, 5];
        //    LinkedListNode<int> current = head;
        //    while (current != null && current.next != null)
        //    {
        //        if (current.val == current.next.val)
        //        {
        //            // Skip the duplicate node
        //            current.next = current.next.next;
        //        }
        //        else
        //        {
        //            current = current.next;
        //        }
        //    }

        //}
    }
}
