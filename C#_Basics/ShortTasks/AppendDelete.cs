namespace ShortPrepareTasks
{
    internal class AppendDelete
    {
        private readonly string s  = "a,b,c";
        private readonly string t  = "d,e,f";
        private readonly int k = 6;
        private readonly List<int> h = [1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5];
        private readonly string word = "word";
        public string AppendAndDelete()
        {
            int commonLength = 0;
            int minLength = Math.Min(s.Length, t.Length);

            //compare 
            for (int i = 0; i < minLength; i++)
            {
                if (s[i] == t[i])
                    commonLength++;
                else
                    break;
            }
            int deletions = s.Length - commonLength;
            int appends = t.Length - commonLength;
            int minOperations = deletions + appends;

            return (minOperations > k) ? "NO" : k >= s.Length + t.Length || (k - minOperations) % 2 == 0 ? "YES" : "NO";
        }

        public int DsignerPdfViewer()
        {
            /*
            List<char> alphabet = new List<char>();

            for (char c = 'a'; c <= 'z'; c++)
            {
                alphabet.Add(c);
            }
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                char letter = (char)('a' + i);
                dic[letter] = h[i];
            }
            var largest = 0;
            foreach(var x in word)
            {
                var big = dic[x];
                if (big> largest)
                {
                    largest = big;
                }
            }
            return word.Length * 1 * largest;
            */
            int largest = 0;

            foreach (char c in word)
            {
                int height = h[c - 'a'];
                largest = Math.Max(largest, height);
            }

            return word.Length * largest*1 ;
        }
    }
}
