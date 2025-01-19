public class Solution {
    public int SubarraySum(int[] nums) 
    {
        int n = nums.Length, ans = 0;
        int[] preSum = new int[n+1]; 
        preSum[0] = nums[0];
        for (int i = 1; i < n; i++)
            preSum[i] = preSum[i-1] + nums[i];
        
        for (int i = 0; i < n; i++)
        {
            int start = Math.Max(0, i-nums[i]);
            if (start == 0)
                ans += preSum[i];
            else 
                ans += preSum[i] - preSum[start-1];
        }

        return ans;
    }
}