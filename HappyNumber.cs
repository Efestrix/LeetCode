public class Solution {
    public bool IsHappy(int n) {

        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = GetSumOfSquares(n);
        }

        return n == 1;
    }

    private int GetSumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}
