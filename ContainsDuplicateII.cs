namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            int[] nums1 = { 1, 0, 1, 1 };
            int k1 = 1;

            int[] nums2 = { 1, 2, 3, 1, 2, 3 };
            int k2 = 2;

            Console.WriteLine(ContainsNearbyDuplicate(nums, k));
            Console.WriteLine(ContainsNearbyDuplicate(nums1, k1));
            Console.WriteLine(ContainsNearbyDuplicate(nums2, k2));

        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    int oldIndex = map[nums[i]];

                    if (Math.Abs(i - oldIndex) <= k)
                        return true;
                }

                map[nums[i]] = i;
            }
            return false;
        }
    }
}
