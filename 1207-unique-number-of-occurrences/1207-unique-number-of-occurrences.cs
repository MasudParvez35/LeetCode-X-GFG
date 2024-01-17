public class Solution {
    public bool UniqueOccurrences(int[] a) 
    {
        Dictionary <int,int> mp = new Dictionary<int,int>();
        Dictionary <int,int> mp1 = new Dictionary<int,int>();
        for (int i = 0; i < a.Length; i++) {
            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            else mp[a[i]]++;
        }
        foreach(var i in mp)
        {
            //Console.WriteLine($"{i.Key} {i.Value}");
            if (!mp1.ContainsKey(i.Value)) mp1[i.Value] = 1;
            else return false;
        }
        return true;
    }
}
