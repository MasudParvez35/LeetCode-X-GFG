public class Solution {
    public int[] ApplyOperations(int[] nums) 
    {
        for (int i = 0; i < nums.Count()-1; i++)    
        {
            if (nums[i] == nums[i+1])
            {
                nums[i] *= 2;
                nums[i+1] = 0;
            }
        }
        int ind = 0;
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] != 0)
            {
                nums[ind++] = nums[i];
            }
        }
        for (int i = ind; i < nums.Count(); i++)
            nums[i] = 0;
        return nums;
    }
}