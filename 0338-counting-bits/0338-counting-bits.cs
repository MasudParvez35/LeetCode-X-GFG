public class Solution {
    public int[] CountBits(int n) 
    {
        int[] ans = new int[n+1];
        for (int i = 1; i <= n; i++)
        {
            int c = 0, t = i;
            while(t > 0)
            {
                if (t % 2 == 1) c++;
                t /= 2;
            }
            ans[i] = c;
        }
        return ans;
    }
}
