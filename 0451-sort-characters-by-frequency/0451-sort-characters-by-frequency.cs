public class Solution {
    public string FrequencySort(string s) 
    {
        int n = s.Length;
        Dictionary<char,int> mp = new Dictionary<char,int>();
        string ans = "";
        for (int i = 0; i < n; i++) 
        {
            if (!mp.ContainsKey(s[i])) mp[s[i]] = 1;
            else mp[s[i]]++;
        }
        List <(int, char)> vp = new List<(int, char)>();
        foreach(var it in mp)
        {
            //Console.WriteLine($"{it.Key} {it.Value}");
            vp.Add((it.Value, it.Key));
        }
        vp.Sort();
        vp.Reverse();
        foreach (var it in vp)
        {
            for (int i = 0; i < it.Item1; i++) ans += it.Item2;
        }
        return ans;
    }
}
