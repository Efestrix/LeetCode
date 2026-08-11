namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Missing Number

            int range = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(
                Console.ReadLine().Split(' '), 
                int.Parse
            );

            Array.Sort(nums);

            int expected = nums[0];

            for (int i = 0; i < range - 1; i++)
            {

                if (nums[i] != expected)
                {
                    Console.WriteLine(expected);
                    break;
                }
                
                expected++;
            }
        }
    }
}
