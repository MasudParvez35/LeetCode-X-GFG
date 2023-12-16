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
                if (b % 2 == 0) {
                    ans++;
                    b /= 2;
                }
                else {
                    ans += 2;
                    b /= 2;
                    b++;
                }
            }
        }
        return ans;
    }
}
