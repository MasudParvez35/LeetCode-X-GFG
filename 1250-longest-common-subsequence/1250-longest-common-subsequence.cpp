class Solution {
public:
    int lcs(string &s, string &t, int i, int j, vector<vector<int>>&dp)
    {
        if (i < 0 or j < 0) return 0;
        if (dp[i][j] != -1) return dp[i][j];
        int take = 0;
        if (s[i] == t[j]) {
            take = 1 + lcs(s, t, i-1, j-1, dp);
        }
        int ntake = max(lcs(s, t, i-1, j, dp), lcs(s, t, i, j-1, dp));
        return dp[i][j] = max(take, ntake);
    }
    int longestCommonSubsequence(string s, string t) 
    {
        int n = s.size(), m = t.size();
        vector<vector<int>> dp(n+1, vector<int>(m+1, -1));
        return lcs(s, t, n-1, m-1, dp);
    }
};