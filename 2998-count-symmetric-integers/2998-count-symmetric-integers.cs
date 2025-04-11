public class Solution {
    private bool Check(int num)
    {
        string s = num.ToString();
        if ((s.Length) % 2 == 1)
            return false;
        int x = 0, y = 0;
        for (int i = 0; i < (s.Length)/2; i++)
        {
            x += (s[i]-'0');
        }
        for (int i = (s.Length)/2; i < s.Length; i++)
        {
            y += (s[i]-'0');
        }
        return x == y ? true : false;
    }
    public int CountSymmetricIntegers(int low, int high) 
    {
        int ans = 0;
        for (int i = low; i <= high; i++)
        {
            bool p = Check(i);
            if (p)
                ans++;
        }
        return ans;
    }
}