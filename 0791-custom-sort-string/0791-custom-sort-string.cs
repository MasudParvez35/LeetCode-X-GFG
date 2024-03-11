public class Solution {
    public string CustomSortString(string t, string s) 
    {
        Dictionary<char, int> mp = new Dictionary<char, int>();
        foreach (char c in s) {
            if (mp.ContainsKey(c))
                mp[c]++;
            else
                mp[c] = 1;
        }
        
        string ans = "";
        
        foreach (char c in t) {
            if (mp.ContainsKey(c) && mp[c] > 0) {
                ans += new string(c, mp[c]);
                mp[c] = -1;
            }
        }
        
        foreach (char c in s) {
            if (mp.ContainsKey(c) && mp[c] != -1)
                ans += c;
        }
        
        return ans;
    }
}