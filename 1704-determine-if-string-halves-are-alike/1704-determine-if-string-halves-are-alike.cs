public class Solution {
    public bool ok(char c) {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || 
           c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            return true;
        else return false;
    }
    public bool HalvesAreAlike(string s) 
    {
        int n = s.Length, c = 0;
        for (int i = 0; i < n/2; i++) {
            if (ok(s[i])) c++;
        }
        for (int i = n/2; i < n; i++) {
            if (ok(s[i])) c--;
        }
        return c == 0;
    }
}