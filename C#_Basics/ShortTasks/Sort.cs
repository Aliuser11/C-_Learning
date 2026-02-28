using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    public class Sort
    {
        private readonly int[] arr = [1, 2, 4, 5, 3];
        private readonly List<int> arr2 = [3, 4, 7, 5, 6, 2, 1];

        public void FullCountingSort()
        {

        }

        public void SortedArray(int n = 5)
        {
            var value = arr[n - 1];
            int j;
            for (j = n - 2; j >= 0; j--)
            {
                if (arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    PrintArray(arr);
                }
                else
                {
                    break;

                }
            }

            arr[j + 1] = value;
            PrintArray(arr);

            void PrintArray(int[] arr)
            {
                foreach (var x in arr)
                    Console.Write(x + " ");
                Console.WriteLine();
            }
        }

        public void SortedArray2(int n = 7)
        {
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;//poprzedni
                var value = arr2[i] ;
                while (j >= 0 && arr2[j] > value)
                {
                    var valuej = arr2[j];
                    arr2[j + 1] = arr2[j];
                    j--;
                }
                arr2[j + 1] = value;
                PrintArray(arr2);
            }

            void PrintArray(List<int> arr2)
            {
                foreach (var x in arr2)
                    Console.Write(x + " ");
                Console.WriteLine();
            }
        }
    }
}
