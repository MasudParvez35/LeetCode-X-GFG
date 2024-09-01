public class Solution {
    public string ReverseWords(string s) 
    {
        s = " " + s;
        string ans = "", temp = "";
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (temp.Length > 0)
                {
                    char[] ss = temp.ToCharArray();
                    Array.Reverse(ss);
                    ans += new string(ss);
                    ans += " ";
                    temp = "";
                }
            }
            else if (s[i] != ' ')
            {
                temp += s[i];
            }
        }
        ans = ans.Remove(ans.Length-1);
        return ans;
    }
}