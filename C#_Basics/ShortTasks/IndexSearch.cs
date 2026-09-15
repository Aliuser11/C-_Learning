namespace ShortPrepareTasks
{
    public interface IIndexSearch
    {
        int FindTargetIndex1();
        int FindTargetIndex2();
        int FirstOccurrence1();
    }
    internal class IndexSearch : IIndexSearch
    {
        private readonly List<int> nums = [1, 2, 3, 4, 5];
        private readonly List<int> occur = [1, 2, 2, 3, 4, 5];
        private readonly int target = 2;

        public int FindTargetIndex1()
        {
            var x = nums.FindIndex(x => x == target);
            return x;
        }

        public int FindTargetIndex2()
        {
            var x = nums.IndexOf(target); // first occurrence
            return x;
        }

        public int FirstOccurrence1()
        {
            return occur.FindIndex(x => x == target); // first occurrence
        }
    }
}
