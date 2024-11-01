public class Solution {
    public string MakeFancyString(string s) 
    {
        if (s.Length <= 2) return s;
        var ans = new System.Text.StringBuilder();
        ans.Append(s[0]);
        ans.Append(s[1]);
        for (int i = 2; i < s.Length; i++)
        {
            if (s[i] == s[i-1] && s[i] == s[i-2]) 
                continue;
            else 
                ans.Append(s[i]);
        }
        return ans.ToString();
    }
}