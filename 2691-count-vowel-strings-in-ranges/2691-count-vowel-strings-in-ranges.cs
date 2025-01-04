public class Solution {
    public bool IsVowel(char c) {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
        else 
            return false;
    }
    public bool Check(string s)
    {
        if (IsVowel(s[0]) && IsVowel(s[s.Length-1]))
            return true;
        else 
            return false;
    }
    public int[] VowelStrings(string[] s, int[][] q) 
    {
        int[] pre = new int[s.Length+1];
        int[] ans = new int[q.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (Check(s[i]) == true)
                pre[i] = 1;
            if (i > 0)
                pre[i] += pre[i-1];
        }
        for (int i = 0; i < q.Length; i++)
        {
            int left = q[i][0];
            int right = q[i][1];
            if (left == 0)
                ans[i] = pre[right];
            else 
                ans[i] = pre[right] - pre[left-1];
        }
        return ans;
    }
}