public class Solution {
    public int Int(string s) {
        int sm = 0;
        foreach(char c in s) {
            sm = (sm*10) + (c-'0');
        }
        return sm;
    }
    public IList<int> SequentialDigits(int l, int h) 
    {
        List<int> ans = new List<int>();
        string s = "123456789";
        for (int x = 2; x <= 9; x++) 
        {
            string p = "";
            for (int i = 0, j = 0; i < s.Length; i++) 
            {
                p += s[i];
                if (i - j + 1 == x) 
                {
                    int y = Int(p);
                    if (y >= l && y <= h) ans.Add(y);
                    j++;
                    p = p.Remove(0,1);
                }
            }
        }
        return ans;
    }
}