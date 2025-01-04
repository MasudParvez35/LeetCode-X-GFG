class Solution {
public:
    bool isVowel(char c) {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
        else 
            return false;
    }
    bool check(string s)
    {
        if (isVowel(s[0]) && isVowel(s.back()))
            return true;
        else 
            return false;
    }
    vector<int> vowelStrings(vector<string>& s, vector<vector<int>>& q) 
    {
        int n = s.size();
        vector <int> pre(n+1, 0), ans(q.size(), 0);
        for (int i = 0; i < s.size(); i++)
        {
            if (check(s[i]) == true)
                pre[i] = 1;
            if (i)
                pre[i] += pre[i-1];
        }

        for (int i = 0; i < q.size(); i++) 
        {
            int left = q[i][0]; 
            int right = q[i][1];
            int x;
            if (left == 0)
                x = pre[right];
            else 
                x = pre[right] - pre[left - 1]; 
            ans[i] = x;
        }
        return ans;
    }
};