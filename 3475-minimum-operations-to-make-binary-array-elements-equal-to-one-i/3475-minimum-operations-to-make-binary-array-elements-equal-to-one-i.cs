public class Solution {
    public int MinOperations(int[] nums) 
    {
        int ans = 0;
        for (int i = 0; i < nums.Length-2; i++)
        {
            if (nums[i] == 0)
            {
                ans++;
                nums[i] = 1;
                nums[i+1] = (nums[i+1]+1)%2;
                nums[i+2] = (nums[i+2]+1)%2;
            }
        }
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == 0)
                return -1;
                
        return ans;
    }
}