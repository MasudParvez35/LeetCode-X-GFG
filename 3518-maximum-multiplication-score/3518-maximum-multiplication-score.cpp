class Solution {
public:
    long long dfs(vector<int>&a, vector<int>&b, int i, int j, 
    vector<vector<long long>>&dp)
    {
        if (i == 4) return 0;
        if (j == b.size())  return -1e9;
        if (dp[i][j] != -1) return dp[i][j];
        long long take = (long long)a[i]*(long long)b[j] + dfs(a, b, i+1, j+1, dp);
        long long ntake = dfs(a, b, i, j+1, dp);
        return dp[i][j] = max(take, ntake);
    }
    long long maxScore(vector<int>& a, vector<int>& b) 
    {
        vector<vector<long long>> dp(4, vector<long long>(b.size()+1, -1));
        return dfs(a, b, 0, 0, dp);
    }
};