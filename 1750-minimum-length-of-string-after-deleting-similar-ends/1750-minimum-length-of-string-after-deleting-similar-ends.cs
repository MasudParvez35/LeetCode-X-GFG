public class Solution {
    public int MinimumLength(string s) 
    {
        int n = s.Length, i = 0, j = s.Length-1, c = 0;
        while(i < j)
        {
            if (s[i] != s[j]) break;
            char ch = s[i];
            while(i <= j && s[i] == ch) {
                i++; 
                c++;
            }
            while(i < j && s[j] == ch) {
                j--;
                c++;
            }
        }
        return n - c;
    }
}