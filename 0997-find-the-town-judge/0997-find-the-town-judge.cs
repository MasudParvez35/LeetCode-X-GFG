public class Solution {
    public int FindJudge(int n, int[][] a) 
    {
        int[] in0 = new int[n+1];
        int[] in1 = new int[n+1];
        foreach (var i in a) {
            in0[i[0]]++;
            in1[i[1]]++;
        }
        foreach (var i in a) {
            if (in1[i[1]] == n-1 && in0[i[1]] == 0) return i[1];
        }
        return n == 1 ? 1 : -1;
    }
}