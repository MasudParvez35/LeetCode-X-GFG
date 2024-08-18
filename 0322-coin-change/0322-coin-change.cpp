class Solution {
public:
    int dp[15][10005];
    int dfs(vector<int>&a, int i, int t)
    {
        if (i < 0 || t < 0) return 1e9;
        if (i == 0) {
            if (t % a[i] == 0) return t/a[i];
            else  return 1e9;
        }
        if (dp[i][t] != -1) return dp[i][t];
        int take = 1 + dfs(a, i, t-a[i]);
        int ntake = dfs(a,i-1,t);
        return dp[i][t] = min(take, ntake);
    }
    int coinChange(vector<int>& a, int t) 
    {
        memset(dp, -1, sizeof(dp));
        int n = a.size();
        int ans = dfs(a,n-1,t);
        return ans >= 1e9 ? -1 : ans;
    }
};