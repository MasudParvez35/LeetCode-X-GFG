public class Solution {
    public int MaximumLengthSubstring(string s) 
    {
        Dictionary <char,int> mp = new Dictionary<char,int>();
        int ans = 0;
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (!mp.ContainsKey(s[i])) mp[s[i]] = 1;
            else mp[s[i]]++;

            while(mp[s[i]] > 2)
            {
                mp[s[j++]]--;
            }
            ans = Math.Max(ans, (i-j)+1);
        }
        return ans;
    }
}