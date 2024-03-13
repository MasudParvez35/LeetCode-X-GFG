public class Solution {
    public int PivotInteger(int n) 
    {
        int sm = 0, sum = (n*(n+1))/2;
        for (int i = 1; i <= n; i++)
        {
            sm += i;
            int x = sum - sm + i;
            if (x == sm) return i;
        }
        return -1;
    }
}