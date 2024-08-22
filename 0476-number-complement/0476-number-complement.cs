public class Solution {
    public int FindComplement(int num) 
    {
        int i = 0, ans = 0;
        while(num > 0)
        {
            int rem = num%2;
            if (rem == 0) ans += (int)Math.Pow(2,i);
            num = num >> 1;
            i++;
        }
        return ans;
    }
}
