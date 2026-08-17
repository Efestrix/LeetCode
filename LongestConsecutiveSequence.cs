namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            int[] nums1 = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            int[] nums2 = { 1, 0, 1, 2 };

            int[] nums3 = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };

            Console.WriteLine(LongestConsecutive(nums));
            Console.WriteLine(LongestConsecutive(nums1));
            Console.WriteLine(LongestConsecutive(nums2));
            Console.WriteLine(LongestConsecutive(nums3));
        }
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>(nums);
            int result = 0;

            foreach (int num in numbers)
            {
                if (!numbers.Contains(num - 1)) {
                    int curr = num;
                    int streak = 1;

                    while (numbers.Contains(curr + 1)) {
                        streak++;
                        curr++;
                    }

                    result = Math.Max(result, streak);
                }
            }
            return result;
        }
    }
}
