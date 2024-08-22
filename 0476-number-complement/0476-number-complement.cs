public class Solution {
    public int FindComplement(int num) 
    {
        int ans = 0;
        string s = "";
        while(num > 0)
        {
            int rem = Math.Abs(num%2-1);
            s += rem;
            num /= 2;
        }
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '1') {
                ans += (int)Math.Pow(2,i);
            }
        }
        return ans;
    }
}