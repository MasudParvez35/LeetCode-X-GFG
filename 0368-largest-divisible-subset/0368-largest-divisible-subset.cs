public class Solution {
    public IList<int> LargestDivisibleSubset(int[] a) 
    {
        List<int> ans = new List<int>();
        Array.Sort(a);
        int mx = 0, val = a[0], n = a.Length;
        int[] dp = new int[n+1];

        for (int i = 1; i < a.Length; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                if (a[i] % a[j] == 0) 
                {
                    dp[i] = Math.Max(dp[i], dp[j]+1);
                    if (dp[i] > mx) 
                    {
                        mx = dp[i];
                        val = a[i];
                    }
                }
            }
        }

        for (int i = n-1; i >= 0; i--)
        {
            if (dp[i] == mx && val % a[i] == 0)
            {
                ans.Add(a[i]);
                mx--;
                val = a[i];
            }
        }
        
        if (ans.Count() == 0) ans.Add(a[0]);
        return ans;
    }
}