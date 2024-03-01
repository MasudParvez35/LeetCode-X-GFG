public class Solution {
    public string MaximumOddBinaryNumber(string t) 
    {
        char[] s = t.ToCharArray();
        Array.Sort(s, (x,y) => y-x);
        for (int i = s.Length-1; i >= 0; i--) 
        {
            if (s[i] == '1') {
                char ch = s[i];
                s[i] = s[s.Length-1];
                s[s.Length-1] = ch;
                break;
            }
        }
        return new string(s);
    }
}