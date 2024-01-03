public class Solution {
    public int NumberOfBeams(string[] s) 
    {
        int ans = 0, prev = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int c = 0;
            for (int j = 0; j < s[i].Length; j++) {
                if (s[i][j] == '1') c++;
            }
            if (prev > 0)
            {
                ans += c*prev;
            }
            if (c > 0) prev = c;
        }
        return ans;
    }
}