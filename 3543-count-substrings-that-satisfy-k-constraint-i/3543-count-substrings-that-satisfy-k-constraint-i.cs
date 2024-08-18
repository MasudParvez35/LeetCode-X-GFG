public class Solution {
    public int CountKConstraintSubstrings(string s, int k) 
    {
        int zero = 0, one = 0, ans = 0;
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (s[i] == '0') zero++;
            else one++;
            while(one > k && zero > k)
            {
                if (s[j++] == '0') zero--;
                else one--;
            }
            ans += i-j+1;
        }
        return ans;
    }
}