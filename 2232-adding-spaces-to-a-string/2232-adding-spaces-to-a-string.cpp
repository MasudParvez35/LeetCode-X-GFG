class Solution {
public:
    string addSpaces(string s, vector<int>& spaces) 
    {
        string ans = "";
        for (int index = 0, j = 0; index < s.size(); index++)
        {
            if (j < spaces.size() && index == spaces[j]) {
                ans += ' ';
                j++;
            }
            ans += s[index];
        }
        return ans;
    }
};