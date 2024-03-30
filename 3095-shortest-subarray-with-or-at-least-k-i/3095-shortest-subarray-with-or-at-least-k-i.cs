public class Solution {
    public int MinimumSubarrayLength(int[] a, int k) 
    {
        int ans = int.MaxValue;
        for (int i = 0; i < a.Length; i++) {
            int x = a[i];
            for (int j = i; j < a.Length; j++) {
                x |= a[j];
                if (x >= k) {
                    ans = Math.Min(ans, j-i+1);
                }
            }
        }
        return ans == int.MaxValue ? -1 : ans;
    }
}
