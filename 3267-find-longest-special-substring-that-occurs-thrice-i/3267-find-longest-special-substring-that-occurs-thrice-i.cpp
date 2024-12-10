class Solution {
public:
    vector <int> ar[200];
    int maximumLength(string s) 
    {
        int n = s.size(), c = 1;
        for (int i = 0; i < s.size()-1; i++)
        {
            if (s[i] == s[i+1]) {
                c++;
            }
            else {
                ar[s[i]-'a'].push_back(c);
                c = 1;
            }
        }
        ar[s.back()-'a'].push_back(c);
        for (int i = 0; i < 26; i++) {
            ar[i].push_back(0);
            ar[i].push_back(0);
            ar[i].push_back(0);
        }
        int ans = -1;
        for (int i = 0; i < 26; i++)
        {
            vector <int> a = ar[i];
            sort(a.rbegin(), a.rend());
            if (a[0]+a[1]+a[2] >= 3) 
            {
                int x = max(a[0]-2, a[2]);
                int y = min(a[0]-1, a[1]);
                ans = max({ans, x, y});
            }
        }
        return ans;
    }
};