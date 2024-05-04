public class Solution {
    public int NumRescueBoats(int[] a, int lmt) 
    {
        Array.Sort(a);
        int ans = 0, i = 0, j = a.Length-1;
        while(i <= j)
        {
            int sum = a[i] + a[j];
            if (sum <= lmt) {
                i++;
                j--;
            }
            else j--;
            ans++;
        }
        return ans;
    }
}