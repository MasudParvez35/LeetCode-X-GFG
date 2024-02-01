public class Solution {
    public int[][] DivideArray(int[] a, int k) 
    {
        int n = a.Length;
        Array.Sort(a);
        int[][] ans = new int[n/3][];
        for (int i = 0, j = 0; i < n; i += 3)
        {
            if (a[i+2] - a[i] > k) return new int[0][];
            else ans[j++] = new int[]{a[i], a[i+1], a[i+2]};
        }
        return ans;
    }
}
