class Solution {
public:
    string customSortString(string t, string s) 
    {
        map <char, int> mp;
        for (auto i : s) mp[i]++;
        string ans;
        for (int i = 0; i < t.size(); i++)
        {
            if (mp[t[i]])
            {
                ans += string(mp[t[i]], t[i]);
                mp[t[i]] = -1;
            }
        }
        for (int i = 0; i < s.size(); i++)
        {
            if (mp[s[i]] != -1)  ans += s[i];
        }
        return ans;
    }
};
