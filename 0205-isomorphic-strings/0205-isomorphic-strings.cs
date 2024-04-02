public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        int[] mp = new int[227];
        int[] pp = new int[227];
        for (int i = 0; i < s.Length; i++) {
            if (mp[s[i]] != pp[t[i]]) return false;
            mp[s[i]] = i+1;
            pp[t[i]] = i+1;
        }
        return true;
    }
}
