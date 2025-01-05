public class Solution {
    public int WaysToSplitArray(int[] nums) 
    {
        long ans = 0, n = nums.Length, sum = 0;
        for (int i = 0; i < n; i++) {
            sum += nums[i];
        }
        long curSum = 0;
        for (int i = 0; i < n-1; i++)
        {
            curSum += nums[i];
            if (2*curSum >= sum)
                ans++;
        }
        return (int)ans;
    }
}