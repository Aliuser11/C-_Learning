using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    public interface ICountPairs
    {
        int Pairs();
    }
    internal class CountPairs : ICountPairs
    {
        private readonly List<int> prices = [1, 2, 3, 4, 5];
        private readonly int budget = 7;

        public int Pairs()
        {
            var counter = 0;

            for (int i = 0; i < prices.Count - 1; i++)
            {
                for (int j = i + 1; j < prices.Count; j++)
                {
                    if (prices[i] + prices[j] <= budget)
                        counter++;
                }
            }

            return counter;
        }
        public List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var aC = 0;
            var bC = 0;
            


            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] > b[i]) 
                {
                    aC++;
                }
                else if (b[i] > a[i])
                {
                    bC++;
                }
                
            }
            return new List<int>() { aC, bC };
        }
    }
}
