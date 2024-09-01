public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        int[] fre = new int[26];
        foreach (char ch in s)
        {
            fre[ch-'a']++;
        }
        foreach (char ch in t)
        {
            fre[ch-'a']--;
        }
        for (int i = 0; i < 26; i++) {
            if (fre[i] != 0)
                return false;
        }
        return true;
    }
}