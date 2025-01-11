public class Solution {
    public bool CanConstruct(string s, int k) 
    {
        Dictionary<char,int> fre = new Dictionary<char,int>();
        foreach (var c in s) {
            if (!fre.ContainsKey(c))
                fre[c] = 1;
            else 
                fre[c]++;
        }
        int unique = 0;
        foreach (var item in fre)
        {
            if (item.Value % 2 == 1)
                unique++;
        }
        if (unique > k || s.Length < k)
            return false;
        else 
            return true;
    }
}