class Solution {
public:
    string reverseWords(string s) 
    {
        s = " " + s;
        string ans = "", temp = "";
        for (int i = s.size()-1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (temp.size() > 0)
                {
                    reverse(begin(temp), end(temp));
                    ans += temp;
                    ans += " ";
                    temp = "";
                }
            }
            else if (s[i] != ' ')
            {
                temp += s[i];
            }
        }
        if (ans[ans.size()-1] == ' ') ans.erase(ans.begin()+ans.size()-1);
        return ans;
    }
};