public class Solution {
    public bool IsArraySpecial(int[] nums) 
    {
        for (int i = 0; i < nums.Length-1; i++)
        {
            if ((nums[i]+nums[i+1]) % 2 == 0)
                return false;
        }
        return true;
    }
}