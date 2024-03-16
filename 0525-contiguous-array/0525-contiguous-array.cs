public class Solution {
    public int FindMaxLength(int[] a) 
    {
        Dictionary<int,int> mp = new Dictionary<int,int>();
        int c = 0, ans = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1) c++;
            else c--;
            if (c == 0) ans = i+1;
            else 
            {
                if (!mp.ContainsKey(c)) mp[c] = i;
                else ans = Math.Max(ans, i-mp[c]);
            }
        }
        return ans;
    }
}