namespace ShortPrepareTasks
{
    public interface IBackwards
    {
        bool CheckBackwardWordOption1();
        bool CheckBackwardWordOption2();
        bool CheckBackwardWordOption3();
    }

    internal class Backwards : IBackwards
    {
        private readonly string code = "A1b2B!a";
        public bool CheckBackwardWordOption1()
        {
            Console.Write("enter word \n");
            var word = Console.ReadLine();
            var wordToLower = word.ToLower();

            var wordBack = new string(wordToLower.Reverse().ToArray());
            return wordBack == wordToLower ? true : false;
        }

        public bool CheckBackwardWordOption3()
        {
            Console.WriteLine(" Palindrome With only letters \n");
            var onlyWithLetters = new string(code.Where(char.IsLetter).ToArray());
            var wordToLower = onlyWithLetters.ToLower();

            var wordBack = new string(wordToLower.Reverse().ToArray());
            return wordBack == wordToLower ? true : false;
        }

        public bool CheckBackwardWordOption2()
        {
            Console.Write("enter word \n");
            string word = Console.ReadLine().ToLower();
            char [] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string backward = new string(charArray);
            return backward == word ? true : false;
        }
    }
}
