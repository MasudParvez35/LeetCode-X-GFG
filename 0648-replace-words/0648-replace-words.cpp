class Solution {
public:
    string replaceWords(vector<string>& s, string t) 
    {
        map <string,int> mp;
        for (int i = 0; i < s.size(); i++) {
            mp[s[i]]++;
        }
        t = t + " ";
        string ans = "", ss, tmp;
        bool f = false;
        for (int i = 0; i < t.size(); i++)
        {
            ss += t[i];
            if (mp[ss]) 
            {
                if (!f) {
                    ans += ss;
                    ans += " ";
                }
                f = true;
            }
            if (t[i] == ' ')
            {
                //cout << ss << " " << f << endl;
                if (f == false)  {
                    ans += ss;
                }
                ss = "";
                f = false;
            }
        }
        ans.pop_back();
        return ans;
    }
};