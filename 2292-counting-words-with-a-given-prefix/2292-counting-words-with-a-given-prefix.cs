public class Solution {
    public int PrefixCount(string[] words, string pref) 
    {
        int ans = 0;
        for (int ind = 0; ind < words.Length; ind++) 
        {
            bool isFind = words[ind].StartsWith(pref);   
            if (isFind)          
                ans++;
        }
        return ans;
    }
}