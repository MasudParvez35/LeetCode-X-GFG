public class Solution {
    public int WaysToSplitArray(int[] nums) 
    {
        int ans = 0, n = nums.Length;
        long[] pre = new long[n];
        pre[0] = nums[0];
        for (int i = 1; i < n; i++) {
            pre[i] = pre[i-1] + nums[i];
        }
        for (int i = 0; i < n-1; i++)
        {
            long left = pre[i];
            long right = pre[n-1] - left;
            if (left >= right)
                ans++;
        }
        return ans;
    }
}