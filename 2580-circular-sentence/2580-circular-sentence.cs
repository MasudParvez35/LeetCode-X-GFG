public class Solution {
    public bool IsCircularSentence(string t) 
    {
        if (string.IsNullOrEmpty(t)) 
            return false;

        StringBuilder s = new StringBuilder(t);
        s.Append(" ").Append(t[0]);
        
        for (int i = 1; i < s.Length - 1; i++) 
        {
            if (s[i] == ' ' && s[i - 1] != s[i + 1]) 
                return false;
        }
        
        return true;
    }
}
