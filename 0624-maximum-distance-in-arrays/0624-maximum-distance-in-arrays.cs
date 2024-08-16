public class Solution {
    public int MaxDistance(IList<IList<int>> ar) 
    {
        int ans = 0;
        int min = ar[0][0];
        int max = ar[0][ar[0].Count - 1];

        for (int i = 1; i < ar.Count; i++)
        {
            int last = ar[i][ar[i].Count - 1];
            int first = ar[i][0];
            ans = Math.Max(ans, Math.Abs(last - min));
            ans = Math.Max(ans, Math.Abs(max - first));

            min = Math.Min(min, first);
            max = Math.Max(max, last);
        }
        return ans;
    }
}