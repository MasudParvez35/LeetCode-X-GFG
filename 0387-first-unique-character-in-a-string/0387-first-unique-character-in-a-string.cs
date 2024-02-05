public class Solution {
    public int FirstUniqChar(string s) 
    {
        int n = s.Length, ind = -1;
        int[] dp = new int[27];
        for (int i = 0; i < n; i++) 
        {
            dp[s[i]-'a']++;
        }
        for (int i = 0; i < n; i++) {
            if (dp[s[i]-'a'] == 1) return i;
        }
        return ind;
    }
}
