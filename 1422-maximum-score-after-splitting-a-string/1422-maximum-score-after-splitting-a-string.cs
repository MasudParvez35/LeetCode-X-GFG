public class Solution {
    public int MaxScore(string s) 
    {
        int n = s.Length, c = 0, ans = 0;
        int[] fre = new int[n];
        for (int i = 0; i < n; i++) {
            if (s[i] == '0') c++;
            fre[i] = c;
        }
        for (int i = 0; i < n-1; i++) {
            int x = fre[i] + (n-i-1) - (fre[n-1]-fre[i]);
            ans = Math.Max(ans, x);
        }
        return ans;
    }
}
