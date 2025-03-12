public class Solution {
    public int MaximumCount(int[] nums) {
        int neg = 0, pos = 0;

        foreach (int num in nums)
        {
            if (num > 0) pos++;
            else if (num < 0) neg++;
        }

        return Math.Max(pos, neg);
        
    }
}
