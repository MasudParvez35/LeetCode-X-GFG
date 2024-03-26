class Solution {
public:
    map <string, int> mp;
    void fun(vector<string>& ss)
    {
        for (int i = 0; i < ss.size(); i++)
        {
            string s = ss[i];
            for (int j = 1; j <= s.size(); j++) 
            {
                for (int k = 0; k <= s.size()-j; k++) 
                {
                    string p = s.substr(k,j);
                    if (p.size()) mp[p]++;
                }
            }
        }
    }
    map <string, int> fun1(string s)
    {
        map <string,int> mp;
        for (int j = 1; j <= s.size(); j++) 
        {
            for (int k = 0; k <= s.size()-j; k++) 
            {
                string p = s.substr(k,j);
                if (p.size()) mp[p]++;
            }
        }
        return mp;
    }
    bool isSorted(string s) {
        for (int i = 0; i < s.size()-1; i++) {
            if (s[i] > s[i+1]) return false;
        }
        return true;
    }
    vector<string> shortestSubstrings(vector<string>& ss) 
    {
        fun(ss);
        vector<string> ans;
        for (int i = 0; i < ss.size(); i++)
        {
            string s = ss[i], t = ss[i];
            map <string,int> pp = fun1(s);
            vector <pair<int, string>> vp;
            for (auto it : pp)
            {
                string x = it.first;
                vp.push_back({(int)x.size(), x});
            }
            sort(vp.begin(), vp.end());
            for (auto it : vp) {
                int y = it.first;
                string x = it.second;
                if (mp[x] == pp[x]) {
                    t = x; break;
                }
                //cout << y << " " << x << endl;
            }
            if (t == ss[i] and mp[ss[i]] != pp[ss[i]]) {
                t = "";
            }
            ans.push_back(t);
            //break;
        }
        return ans;    
    }
};
