public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) 
    {
        Dictionary<int,int> fre = new Dictionary<int,int>();
        Array.Sort(banned);
        int ans = 0, sum = 0;
        foreach (var val in banned) 
            fre[val] = 1;

        for (int val = 1; val <= n; val++)
        {
            if (fre.ContainsKey(val))
                continue;

            if (sum + val > maxSum)
                break;
            
            ans++;
            sum += val;
        }
        return ans;
    }
}