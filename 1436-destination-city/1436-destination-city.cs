public class Solution {
    public string DestCity(IList<IList<string>> s) 
    {
        Dictionary<string,int> mp = new Dictionary<string,int>();
        for (int i = 0; i < s.Count(); i++)
        {
            if (!mp.ContainsKey(s[i][0])) mp[s[i][0]] = 0;
            mp[s[i][0]] = 1;
        }
        for (int i = 0; i < s.Count(); i++)
        {
            if (!mp.ContainsKey(s[i][1])) return s[i][1];
        }
        return "";
    }
}
