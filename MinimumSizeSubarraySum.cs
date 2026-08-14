namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            int result = MinSubArrayLen(target, nums);

            Console.WriteLine(result);
        }
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int sum = 0;
            int minLength = int.MaxValue;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    int currentLength = right - left + 1;

                    if (currentLength < minLength)
                        minLength = currentLength;

                    sum -= nums[left];
                    left++;
                }
            }

            if (minLength == int.MaxValue)
                return 0;

            return minLength;
        }
    }
}
