public class Solution {
    public int MissingNumber(int[] nums) {
        
        int currentNum = 0;

        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (currentNum == nums[i])
            {
                currentNum++;
            }
            else if (currentNum != nums[i])
            {
                return currentNum;
            }
        }
        return currentNum;
    }
}
