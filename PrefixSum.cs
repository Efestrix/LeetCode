namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 1, 5, 3 };

            int[] prefix = new int[nums.Length + 1];

            for (int i = 0; i <= nums.Length; i++)
            {
                if (i == 0)
                    prefix[i] = 0;
                else
                    prefix[i] = prefix[i - 1] + nums[i - 1];
            }
        }
    }
}
