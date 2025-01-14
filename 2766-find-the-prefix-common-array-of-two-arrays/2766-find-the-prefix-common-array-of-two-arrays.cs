public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        int n = A.Length;
        int[] freA = new int[50+1];
        int[] freB = new int[50+1];
        int[] ans = new int[n];

        for (int ind = 0; ind < n; ind++)
        {
            freA[A[ind]]++;
            freB[B[ind]]++;
            int cnt = 0;
            for (int num = 1; num <= n; num++)
            {
                if (freA[num] != 0 && freA[num] == freB[num])
                    cnt++;
            }
            ans[ind] = cnt;
        }
        return ans;
    }
}