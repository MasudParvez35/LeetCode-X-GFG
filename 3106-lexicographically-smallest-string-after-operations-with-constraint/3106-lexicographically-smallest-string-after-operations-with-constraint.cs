public class Solution {
    public string GetSmallestString(string s, int k) 
    {
        int sm = 0;
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            int f = 0;
            for (char j = 'a'; j <= 'z'; j++)
            {
                if (s[i] > j)
                {
                    int x = s[i]-'a', y = j-'a';
                    int z = Math.Abs(x-y);
                    z = Math.Min(z, ((25-x)+y+1));
                    if (sm + z <= k) 
                    {
                        f = 1; 
                        sm += z;
                        ans += j;
                        break;
                    }
                }
            }
            if (f == 0) ans += s[i];
        }
        return ans;
    }
}