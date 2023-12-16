public class Solution {
    public int BrokenCalc(int a, int b) 
    {
        int ans = 0;
        while(b != a)
        {
            if (b < a)
            {
                ans += a-b;
                b = a;
            }
            else {
                if (b % 2 != 0) 
                {
                    ans++; b++;
                }
                b /= 2;
                ans++;
            }
        }
        return ans;
    }
}
