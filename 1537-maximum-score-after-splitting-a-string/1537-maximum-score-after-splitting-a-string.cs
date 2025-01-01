public class Solution {
    public int MaxScore(string s) 
    {
        int ans = 0;
        for (int mid = 0; mid < s.Length-1; mid++)
        {
            int zero = 0, one = 0;
            for (int left = 0; left <= mid; left++) {
                if (s[left] == '0')
                    zero++;
            }

            for (int right = mid+1; right < s.Length; right++) {
                if (s[right] == '1')
                    one++;
            }

            ans = Math.Max(ans, one+zero);
        }

        return ans;
    }
}