public class Solution {
    public int ScoreOfString(string s) {
        int zbytek = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            int helpNum = (int)s[i];
            int helpNum1 = (int)s[i + 1];
            zbytek += Math.Abs(helpNum - helpNum1);
        }
        return zbytek;
    }
}
