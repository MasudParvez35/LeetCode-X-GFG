class Solution {
public:
    int takeCharacters(string s, int k) 
    {
        map <char,int> mp, mm;
        int n = s.size(), mx = 0;
        for (int i = 0; i < n; i++) mp[s[i]]++;
        for (char ch = 'a'; ch <= 'c'; ch++)
        {
            if (mp[ch] < k) return -1;
        }
        int a = mp['a'] - k, b = mp['b']-k, c = mp['c']-k;
        cout << a << " " << b << " " << c << endl;
        for (int i = 0, j = 0; i < n; i++)
        {
            mm[s[i]]++;
            if (s[i] == 'a')
            {
                while(mm[s[i]] > a)
                {
                    mm[s[j]]--;
                    if (!mm[s[j]]) mp.erase(s[j]);
                    j++;
                }
            }
            else if (s[i] == 'b')
            {
                while(mm[s[i]] > b)
                {
                    mm[s[j]]--;
                    if (!mm[s[j]]) mp.erase(s[j]);
                    j++;
                }
            }
            else if (s[i] == 'c')
            {
                while(mm[s[i]] > c)
                {
                    mm[s[j]]--;
                    if (!mm[s[j]]) mp.erase(s[j]);
                    j++;
                }
            }
            //cout << i << " " << j << endl;
            mx = max(mx,i-j+1);
        }
        return n-mx;
    }
};