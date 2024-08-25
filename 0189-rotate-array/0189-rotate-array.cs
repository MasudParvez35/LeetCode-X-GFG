public class Solution {
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    public void Rotate(int[] nums, int k) 
    {
        int n = nums.Count();
        k %= n;
        Array.Reverse(nums);

        int i = 0, j = k-1;
        while (i < j) {
            Swap(nums, i++, j--);
        }

        i = k; j = n-1;
        while (i < j) {
            Swap(nums, i++, j--);
        }
    }
}