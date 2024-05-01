public class Solution {
    public string ReversePrefix(string s, char c) 
    {
        int j = s.IndexOf(c);
        Console.WriteLine(j);
        string ss = "";
        for (int i = j; i >= 0; i--) ss += s[i];
        for (int i = j+1; i < s.Length; i++) ss += s[i];
        return ss;
    }
}
