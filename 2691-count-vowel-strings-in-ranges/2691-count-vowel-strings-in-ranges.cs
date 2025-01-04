public class Solution {
    public int[] VowelStrings(string[] s, int[][] q) 
    {
        int[] pre = new int[s.Length+1];
        int[] ans = new int[q.Length];
        for (int i = 0; i < s.Length; i++) {
            pre[i + 1] = pre[i] + (IsVowel(s[i][0]) && IsVowel(s[i][s[i].Length - 1]) ? 1 : 0);
        }
        for (int i = 0; i < q.Length; i++)
        {
            int left = q[i][0];
            int right = q[i][1];
            ans[i] = pre[right+1] - pre[left];
        }
        return ans;
    }
    private bool IsVowel(char c) {
        return "aeiou".Contains(c);
    }
}