public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        List<string> nums = new List<string>();

        for (int i = 1; i < n + 1; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                nums.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                nums.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                nums.Add("Buzz");
            }
            else
            {
                nums.Add(i.ToString());
            }
        }
        return nums;
    }
}
