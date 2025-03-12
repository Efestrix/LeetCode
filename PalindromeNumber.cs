public class Solution {
    public bool IsPalindrome(int x) {

        if (x < 0) return false;

        string original = x.ToString();
        char[] pali1 = original.ToCharArray();
        Array.Reverse(pali1);
        string reversed = new string(pali1);

        return original == reversed;
    }
}
