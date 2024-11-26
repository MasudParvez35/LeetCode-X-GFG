public class Solution {
    public int FindChampion(int n, int[][] a) 
    {
        int[] v = new int[n];
        for (int i = 0; i < n; i++) v[i] = 0;
        for (int i = 0; i < a.Length; i++) {
            v[a[i][1]]++;
        }
        int ans = -1, c = 0;
        for (int i = 0; i < n; i++) {
            if (v[i] == 0) {
                ans = i;
                c++;
            }
        }
        if (c == 1) return ans;
        else return -1;
    }
}