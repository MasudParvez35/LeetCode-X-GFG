public class Solution {
    public IList<int> PartitionLabels(string s) 
    {
        var ans = new List<int>();
        var fre = new Dictionary<char, int>();
        for (var ind = 0; ind < s.Length; ind++)
                fre[s[ind]] = ind;
        
        int right = fre[s[0]];
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (i == right)
            {
                ans.Add((i-j+1));
                j = Math.Min(i+1, s.Length-1);
                right = fre[s[j]];
            }
            else 
                right = Math.Max(right, fre[s[i]]);
        }
        return ans;
    }
}