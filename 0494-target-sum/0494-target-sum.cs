public class Solution {
    private int ans = 0;
    public void Dfs(int[] nums, int ind, int sum, int target)
    {
        if (ind == nums.Length)
        {
            if (sum == target)
                ans++;
            return;
        }
        Dfs(nums, ind+1, sum+nums[ind], target);
        Dfs(nums, ind+1, sum-nums[ind], target);
    }
    public int FindTargetSumWays(int[] nums, int target) 
    {
        Dfs(nums, 0, 0, target);
        return ans;
    }
}