public class Solution {
    public int MinimumPushes(string s) 
    {
        int[] fre = new int[26];
        Array.Fill(fre, 0);
        List <int> v = new List<int>();
        int ans = 0, f = 1;
        for (int i = 0; i < s.Length; i++) {
            fre[s[i]-'a']++;
        }
        for (int i = 0; i < 26; i++) {
            if (fre[i] > 0) v.Add(fre[i]);
        }
        v.Sort((x,y) => {
            return y-x;
        });
        for (int i = 0; i < v.Count(); i++)
        {
            ans += v[i]*f;
            if ((i+1) % 8 == 0) f++;
        }
        return ans;
    }
}