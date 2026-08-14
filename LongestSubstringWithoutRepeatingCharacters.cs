namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "pwwkew";
            int num = LengthOfLongestSubstring(s);
            Console.WriteLine(num);
        }
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            int left = 0;
            int length = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char letter = s[right];

                while (letters.ContainsKey(letter))
                {
                    letters.Remove(s[left]);
                    left++;
                }

                letters.Add(letter, 1);

                length = Math.Max(length, right - left + 1);
            }

            return length;
        }
    }
}
