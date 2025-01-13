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
            var x = item.Value;
            if (x % 2 == 0)
                x--;
            if (x >= 2)
            {
                ans -= x;
                if (x % 2 == 1)
                    ans++;
            }
        }

        return ans;
    }
}