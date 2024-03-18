public class Solution {
    public int FindMinArrowShots(int[][] a) 
    {
        Array.Sort(a, (x,y) => {
            return x[1] - y[1];
        });
        int ans = 1, x = a[0][1];
        for (int i = 1; i < a.Length; i++)
        {
            if (x >= a[i][0] && x <= a[i][1]) continue;
            else {
                ans++;
                x = a[i][1];
            }
        }
        return ans;
    }
}
