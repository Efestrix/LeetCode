public class Solution {
    public int RomanToInt(string s) {
        var romanNumerals = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 } 
        };
        

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];

            int currentValue = romanNumerals[currentChar];

            if (i < s.Length - 1)
            {
                char nextChar = s[i + 1];
                int nextValue = romanNumerals[nextChar];

                if (currentValue < nextValue)
                {
                    total -= currentValue;
                }
                else 
                {
                    total += currentValue;
                }
            }
            else
            {
                total += currentValue;
            }
        }
        return total;
    }
}
