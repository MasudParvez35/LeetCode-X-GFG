class Solution {
public:
    int dfs(vector<int>&a, int i, vector<int>&dp)
    {
        if (i < 0) return 0;
        if (dp[i] != -1) return dp[i];
        int take = a[i] + dfs(a, i-2, dp);
        int ntake = dfs(a, i-1, dp);
        return dp[i] = max(take, ntake);
    }
    int rob(vector<int>& a) 
    {
        if (a.size() == 1) return a[0];
        vector <int> v1(a.begin()+1, a.end());
        vector <int> v2(a.begin(), a.end()-1);
        int n = v1.size();

        vector<int> dp(n, -1);
        int x = dfs(v1, n-1, dp);
        fill(dp.begin(), dp.end(), -1);
        int y = dfs(v2, n-1, dp);

        return max(x, y);
    }
};