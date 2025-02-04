public class Solution {
    public int LongestMonotonicSubarray(int[] nums) 
    {
        int ans = 1, count = 1, count1 = 1;
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i+1] > nums[i])
            {
                count++;
                ans = Math.Max(ans, count1);
                count1 = 1;
            }
            else if (nums[i] > nums[i+1])
            {
                count1++;
                ans = Math.Max(ans, count);
                count = 1;
            }
            else 
            {
                ans = Math.Max(ans, count);
                ans = Math.Max(ans, count1);
                count = 1;
                count1 = 1;
            }
        }
        ans = Math.Max(ans, count);
        ans = Math.Max(ans, count1);
        return ans;
    }
}