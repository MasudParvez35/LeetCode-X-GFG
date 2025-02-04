public class Solution {
    public int MaxAscendingSum(int[] nums) 
    {
        int ans = nums[0], sum = nums[0];
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i+1] > nums[i])
            {
                sum += nums[i+1];
            }
            else 
            {
                ans = Math.Max(ans, sum);
                sum = nums[i+1];
            }
        }
        return Math.Max(ans, sum);
    }
}