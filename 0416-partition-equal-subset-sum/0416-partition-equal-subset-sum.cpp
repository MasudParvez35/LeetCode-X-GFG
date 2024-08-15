class Solution {
public:
    bool dfs(vector<int>&a, int i, int sm, vector<vector<int>>&dp)
    {
        if (sm == 0) return 1;
        if (sm < 0 or i < 0) return 0;
        if (dp[i][sm] != -1) return dp[i][sm];
        int ntake = dfs(a, i-1, sm, dp);
        int take = dfs(a, i-1, sm-a[i], dp);
        return dp[i][sm] = take || ntake;
    }
    bool canPartition(vector<int>& nums) 
    {
        int sm = 0, n = nums.size();
        for (auto num : nums) sm +=  num;
        if (sm % 2) return false;
        else 
        {
            vector<vector<int>> dp(n+1, vector<int>(sm/2+1, -1));
            bool f = dfs(nums, n-1, sm/2, dp);
            return f;
        }
    }
};