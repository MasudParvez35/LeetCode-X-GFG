class Solution {
public:
    int dfs(vector<int>&a, int i, int t, vector<vector<int>>&dp)
    {
        if (i < 0 || t < 0) return 0;
        if (i == 0) {
            if (t % a[i] == 0) return 1;
            else return 0;
        }
        if (dp[i][t] != -1) return dp[i][t];
        int take = dfs(a, i, t-a[i], dp);
        int ntake = dfs(a, i-1, t, dp);

        return dp[i][t] = take + ntake;
    }
    int change(int t, vector<int>& a) 
    {
        int n = a.size();
        vector<vector<int>>dp(n+1, vector<int>(t+1, -1));
        int ans = dfs(a,n-1,t,dp);
        return ans;
    }
};