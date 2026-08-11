public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        int largestNum = nums[0];
        int shortestNum = nums[0];
        List<int> missingNums = new List<int>();

        // 1 4 2 5
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > largestNum)
                largestNum = nums[i]; // 5
            else if (nums[i] < shortestNum)
                shortestNum = nums[i]; // 1
        }

        for (int i = shortestNum; i < largestNum; i++)
        {
            if (!nums.Contains(i))
                missingNums.Add(i);
        }

        return missingNums;
    }
}
