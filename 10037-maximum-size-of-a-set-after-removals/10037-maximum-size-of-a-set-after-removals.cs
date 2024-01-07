public class Solution {
    public int MaximumSetSize(int[] a, int[] b) 
    {
        Dictionary<int,int> ma = new Dictionary<int,int>();
        Dictionary<int,int> mb = new Dictionary<int,int>();
        Dictionary<int,int> mm = new Dictionary<int,int>();
        Dictionary<int,int> mp = new Dictionary<int,int>();
        int n = a.Length;
        for (int i = 0; i < a.Length; i++) 
        {
            if (!ma.ContainsKey(a[i])) ma[a[i]] = 1;
            else ma[a[i]]++;
            if (!mb.ContainsKey(b[i])) mb[b[i]] = 1;
            else mb[b[i]]++;

            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            if (!mp.ContainsKey(b[i])) mp[b[i]] = 1;
        }
        int sa = 0, sb = 0, ans = mp.Count();
        foreach(var it in ma) {
            sa += it.Value-1;
        }
        foreach(var it in mb) {
            sb += it.Value-1;
        }
        //Console.WriteLine(sa + " " + sb + " " + ans);
        if (sa < n/2)
        {
            foreach(var it in ma)
            {
                if (mb.ContainsKey(it.Key)) {
                    sa++;
                    if (!mm.ContainsKey(it.Key)) mm[it.Key] = 1;
                    else mm[it.Key]++;
                    if (sa == n/2) break;
                }
            }
        }
        foreach(var it in mb)
        {
            if (ma.ContainsKey(it.Key) && !mm.ContainsKey(it.Key)) {
                sb++;
                if (sb == n/2) break;
            }
        }
        //Console.WriteLine(sa + " " + sb);
        if (sa < n/2) ans -= n/2-sa;
        if (sb < n/2) ans -= n/2-sb;
        return ans;
    }
}