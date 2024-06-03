public class Solution {
    public int AppendCharacters(string s, string t) 
    {
        int n = t.Length;
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (s[i] == t[j])
            {
                n--;
                if (n == 0) break;
                j++;
            }
        }
        return n;
    }
}