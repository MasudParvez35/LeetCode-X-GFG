public class Solution {
    public int MinimumLength(string s) 
    {
        int ans = s.Length;
        var fre = new Dictionary<char,int>();
        foreach (var c in s)
        {
            if (!fre.ContainsKey(c))
                fre[c] = 1;
            else 
                fre[c]++;
        }

        foreach (var item in fre)
        {
            var value = item.Value;
            ans -= (value%2 == 1) ? value-1 : value-2;
        }

        return ans;
    }
}