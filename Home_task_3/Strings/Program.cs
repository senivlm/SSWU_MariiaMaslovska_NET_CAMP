 namespace Strings
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Task 2.
            string str = "Today is a sunny dday Today Day day";

            // a) get index of second occurance (n = 2) of substr
            string substr = "Today";
            int n = 2;

            int? index = GetIndex(str, substr, n);
            if (index != null)
            {
                Console.WriteLine($"The index of the {n} occurrence of \"{substr}\" is {index}.");
            }
            else
            {
                Console.WriteLine($"The {n} occurrence of \"{substr}\" does not exist in the text.");
            }

            // b) count the number of words that begin with an upper-case letter 
            int count = CountNumber(str);
            Console.WriteLine($"The number of words that begin with an upper-case letter equals {count}.");

            // c) replace all words that include double letters with the user string
            string phrase = "hi";
            Console.WriteLine(ReplaceWith(str, phrase));
        }

        public static string ReplaceWith(string str, string substr)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j + 1 != words[i].Length && words[i][j] == words[i][j + 1])
                    {
                        words[i] = substr;
                        break;
                    }
                }
            }

            string newstr = String.Join(" ", words);

            return newstr;
        }

        public static int CountNumber(string str)
        {
            int count = 0;

            string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strArr.Length; i++)
            {
                if (char.IsUpper(strArr[i][0]))
                {
                    count++;
                }
            }

            return count;
        }

        public static int? GetIndex(string str, string substr, int number)
        {
            int count = 0;
            int index = -1;

            do
            {
                index = str.IndexOf(substr, index + 1);
                if (index != -1)
                {
                    count++;
                }
            }
            while (index != -1 && count < number);

            return count == number ? (int?)index : null;
        }
    }
}