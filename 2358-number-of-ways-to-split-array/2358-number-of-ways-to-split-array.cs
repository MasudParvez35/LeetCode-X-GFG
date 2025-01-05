public class Solution {
    public int WaysToSplitArray(int[] nums) 
    {
        int ans = 0;
        long n = nums.Length, TotalSum = 0, curSum = 0;
        for (int i = 0; i < n; i++)
            TotalSum += nums[i];

        for (int i = 0; i < n-1; i++)
        {
            curSum += nums[i];
            if (2*curSum >= TotalSum)
                ans++;
        }
        return ans;
    }
}