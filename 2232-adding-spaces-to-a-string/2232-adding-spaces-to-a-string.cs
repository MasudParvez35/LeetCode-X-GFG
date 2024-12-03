public class Solution {
    public string AddSpaces(string s, int[] spaces) 
    {
        StringBuilder ans = new StringBuilder();
        for (int index = 0, j = 0; index < s.Length; index++)
        {
            if (j < spaces.Length && index == spaces[j]) {
                ans.Append(' ');
                j++;
            }
            ans.Append(s[index]);
        }
        return ans.ToString();
    }
}