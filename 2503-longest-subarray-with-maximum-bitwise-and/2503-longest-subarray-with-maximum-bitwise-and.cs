public class Solution {
    public int LongestSubarray(int[] nums) 
    {
        int ans = 0, c = 0, mx = nums[0];
        foreach (int num in nums) 
            mx = Math.Max(mx, num);
            
        foreach (int num in nums) {
            if (num == mx) {
                c++;
                ans = Math.Max(ans, c);
            }
            else {
                c = 0;
            }
        }
        return ans;
    }
}