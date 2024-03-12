public class Solution {
    public long MaximumHappinessSum(int[] a, int k) 
    {
        long ans = 0;
        Array.Sort(a);
        Array.Reverse(a);
        for (int i = 0; i < k; i++) {
            Console.Write(a[i] + " ");
        }
        for (int i = 0; i < k; i++) {
            if (a[i]-i <= 0) break;
            ans += a[i]-i;
        }
        return ans;    
    }
}