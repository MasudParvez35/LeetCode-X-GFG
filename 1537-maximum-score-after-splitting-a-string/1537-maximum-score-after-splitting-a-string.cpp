class Solution {
public:
    int maxScore(string s) 
    {
        int n = s.size(), on = 0, ze = 0, ans = 0;
        int one[n+1], zero[n+1];
        for (int i = 0; i < n; i++) {
            if (s[i] == '0')
                ze++;
            else 
                on++;
            
            one[i] = on;
            zero[i] = ze;
        }
        for (int i = 0; i < n-1; i++)
        {
            ans = max(ans, zero[i]+(one[n-1]-one[i]));
        }
        return ans;
    }
};