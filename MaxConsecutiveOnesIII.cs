namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 2;

            int[] nums1 = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int k1 = 3;
            
            Console.WriteLine(LongestOnes(nums, k));
            Console.WriteLine(LongestOnes(nums1, k1));
        }
        public static int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int countNull = 0;
            int length = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    countNull++;
                    while (countNull > k)
                    {
                        if (nums[left] == 0)
                        {
                            countNull--;
                        }
                        left++;
                    }
                }
                
                length = Math.Max(length, right - left + 1);
            }
            return length;
        }

    }
}
