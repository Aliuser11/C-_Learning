namespace ShortPrepareTasks
{
    public interface IFindMissingInt
    {
        int SmallestIntegerFinder1();   
        int SmallestIntegerFinder2();   
    }

    internal class FindMissingInt : IFindMissingInt
    {
        private readonly List<int> orderNumbers = [3, 4, -1, 1];
        public int SmallestIntegerFinder1()
        {
            var sorted = orderNumbers.OrderBy(x => x).Distinct().ToArray();
            var counter = 1;
            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] <= 0)
                {
                    continue;
                }
                else if (sorted[i] == counter)
                {
                    counter++;
                }
                else return counter;
            }
            return counter++;
        }

        public int SmallestIntegerFinder2()
        {
            for(int i = 0; i < orderNumbers.Count; i++)
            {
                while(orderNumbers[i] > 0 && orderNumbers[i] <= orderNumbers.Count && orderNumbers[orderNumbers[i] - 1] != orderNumbers[i])
                {
                    var x = orderNumbers[i];
                    orderNumbers[i] = orderNumbers[x - 1];
                    orderNumbers[x - 1] = x;
                }
            }
            for(int x = 0; x< orderNumbers.Count; x++)
            {
                if (orderNumbers[x] != x + 1) { return x + 1; }
            }
            return orderNumbers.Count + 1;
        }
    }
}
