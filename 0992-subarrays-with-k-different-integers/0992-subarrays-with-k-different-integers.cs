public class Solution {
    public int fun(int[] a, int k)
    {
        int sm = 0;
        Dictionary<int, int> mp = new ();
        for (int i = 0, j = 0; i < a.Length; i++)
        {
            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            else mp[a[i]]++;
            while (mp.Count > k)
            {
                mp[a[j]]--;
                if (mp[a[j]] == 0) mp.Remove(a[j]);
                j++;
            }
            sm += i - j;
        }
        return sm;
    }
    public int SubarraysWithKDistinct(int[] a, int k) 
    {
        return fun(a,k) - fun(a,k-1);
    }
}