public class Solution {
    public int MaxScore(string s) 
    {
        int n = s.Length, on = 0, ze = 0, ans = 0;
        int[] one = new int[n];
        int[] zero = new int[n];
        for (int i = 0; i < n; i++) 
        {
            if (s[i] == '0')
                ze++;
            else 
                on++;
            
            one[i] = on;
            zero[i] = ze;
        }
        for (int i = 0; i < n-1; i++)
        {
            ans = Math.Max(ans, zero[i]+(one[n-1]-one[i]));
        }
        return ans;
    }
}