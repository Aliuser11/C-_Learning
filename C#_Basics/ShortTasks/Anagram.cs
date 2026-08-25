namespace ShortPrepareTasks
{
    internal class Anagram
    {
        //private readonly string s  = "listen";
        //private readonly string t  = "silent";

        private readonly string s  = "syrop";
        private readonly string t  = "spory";

        public int CheckAnagram1()
        {
            var ss = s.ToCharArray().OrderBy(c => c);
            var tt = t.ToCharArray().OrderBy(c => c);

            return tt.SequenceEqual(ss) ? 1 : 0;
        }

        public int CheckAnagram2()
        {
            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c)) ? 1 : 0;
        }
    }
}
