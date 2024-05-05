public class Solution {
    public int MinAnagramLength(string s) 
    {
        Dictionary<char, int> mp = new Dictionary<char, int>();
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            if (!mp.ContainsKey(s[i]))
                mp[s[i]] = 1;
            else
                mp[s[i]]++;
            
            if (n % (i + 1) == 0)
            {
                bool f = true;
                for (int j = 0; j < n; j += (i + 1))
                {
                    Dictionary<char, int> tmp = new Dictionary<char, int>();
                    for (int k = j; k < j + (i + 1); k++)
                    {
                        if (!tmp.ContainsKey(s[k]))
                            tmp[s[k]] = 1;
                        else
                            tmp[s[k]]++;
                    }
                    if (!AreEqual(tmp, mp)) {
                        f = false;
                        break;
                    }
                }
                if (f) return i + 1;
            }
        }
        return n;
    }
    
    private bool AreEqual(Dictionary<char, int> a, Dictionary<char, int> b)
    {
        if (a.Count != b.Count)
            return false;
        
        foreach (var pair in a)
        {
            if (!b.ContainsKey(pair.Key) || b[pair.Key] != pair.Value)
                return false;
        }
        return true;
    }    
}