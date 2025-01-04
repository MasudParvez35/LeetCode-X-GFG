class Solution {
public:
    bool vowel(char c) {
        return c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u';
    }
    vector<int> vowelStrings(vector<string>& a, vector<vector<int>>& b) 
    {
        int n = a.size(), len = b.size();
        vector <int> v(n), ans(len), pre(n);
        for (int i = 0; i < n; i++)
        {
            string s = a[i];
            if (vowel(s[0]) and vowel(s.back())) v[i] = 1;
        }
        //for (auto i : v) cout << i << " "; cout << endl;
        pre = v;
        for (int i = 1; i < n; i++) pre[i] += pre[i-1];
        //for (auto i : pre) cout << i << " "; cout << endl;

        for (int i = 0; i < len; i++)
        {
            int l = b[i][0], r = b[i][1];
            ans[i] = pre[r] - pre[l] + v[l];
        }
        return ans;
    }
};