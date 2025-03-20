public class Solution {
    public bool DivideArray(int[] nums) 
    {
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length-1; i += 2)
        {
            if (nums[i] != nums[i+1])
                return false;
        }
        return true;
    }
}