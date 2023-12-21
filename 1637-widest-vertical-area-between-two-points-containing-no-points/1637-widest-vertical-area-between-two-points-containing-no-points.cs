public class Solution {
    public int MaxWidthOfVerticalArea(int[][] aa) 
    {
        int ans = 0;
        int[] a = new int[aa.Length];
        for (int i = 0; i < aa.Length; i++) {
            a[i] = aa[i][0];
        }
        Array.Sort(a);
        for (int i = 1; i < a.Length; i++) {
            ans = Math.Max(ans, a[i]-a[i-1]);
        }
        return ans;    
    }
}
