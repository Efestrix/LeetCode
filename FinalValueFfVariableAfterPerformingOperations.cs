public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;

        
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++")
                {
                    x += 1;
                }
                else if (operations[i] == "--X" || operations[i] == "X--")
                {
                    x -= 1;
                }
            }
        return x;
    }
}
