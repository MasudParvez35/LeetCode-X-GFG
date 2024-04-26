class Solution {
public:
    int solve(vector<vector<int>>&a, int i, int j, vector<vector<int>>&dp)
    {
        //if (j >= a.size()) return 1e9;
        if (i == a.size()-1) return a[i][j];
        if (dp[i][j] != -1) return dp[i][j];
        int x = 1e9;
        for (int k = 0; k < a.size(); k++)
        {
            if (j != k)
            {
                x = min(x, solve(a,i+1,k,dp));
            }
        }
        return dp[i][j] = a[i][j] + x;
    }
    int minFallingPathSum(vector<vector<int>>& a) 
    {
        int n = a.size(), ans = INT_MAX;
        vector <vector<int>> dp(n+1, vector<int>(n+1, -1));
        for (int j = 0; j < n; j++) {
            ans = min(ans, solve(a,0,j,dp));
        }
        return ans;
    }
};