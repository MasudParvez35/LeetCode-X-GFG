class Solution {
public:
    int dfs(vector<int>&a, int i, int t, vector<vector<int>>&dp)
    {
        if (i < 0 || t < 0) return 1e9;
        if (i == 0) {
            if (t % a[i] == 0) return t/a[i];
            else return 1e9;
        }
        if (dp[i][t] != -1) return dp[i][t];
        int take = 1 + dfs(a, i, t-a[i], dp);
        int ntake = dfs(a, i-1, t, dp);
        return dp[i][t] = min(take, ntake);
    }
    int coinChange(vector<int>& a, int t) 
    {
        int n = a.size();
        vector<vector<int>> dp(n+1, vector<int>(t+1, -1));
        int ans = dfs(a,n-1,t,dp);
        return ans >= 1e9 ? -1 : ans;
    }
};