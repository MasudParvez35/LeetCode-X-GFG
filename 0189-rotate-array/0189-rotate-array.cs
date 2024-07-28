public class Solution {
    public void Rotate(int[] nums, int k) 
    {
        k %= nums.Length;
        int index = nums.Length - k;
        int[] arr = nums.ToArray();
        
        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            if (i < k) nums[i] = arr[index++];
            else nums[i] = arr[j++];
        }
    }
}