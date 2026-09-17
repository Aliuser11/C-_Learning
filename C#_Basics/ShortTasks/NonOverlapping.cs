using System.Reflection.Metadata.Ecma335;

namespace ShortPrepareTasks
{
    public interface INonOverlapping
    {
        int CountNonOverlappingOccurrences1();
        int CountNonOverlappingOccurrences2();
    }
    internal class NonOverlapping : INonOverlapping
    {
        private readonly List<List<int>> meetings = [[0, 5], [0, 1], [1, 2], [2, 3], [3, 5], [4, 6]];
        public int CountNonOverlappingOccurrences1()
        {
            var countMeetings = 0;
            var LastEnding = 0;
            var ordered = meetings.OrderBy(x => x.Last()).ThenByDescending(x=>x.First()).ToList(); // [[0,1],[1,2],[2,3],[3,5],[0,5],[4,6]].
            foreach (var m in ordered)
            {
                var start = m.First();
                var ending = m.Last();
                if (start >= LastEnding)
                {
                    countMeetings++;
                    LastEnding = ending;
                }
                else continue;
            }
            return countMeetings;
        }

        public int CountNonOverlappingOccurrences2()
        {
            return 0;
        }
    }
}
