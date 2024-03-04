public class Solution {
    public int BagOfTokensScore(int[] a, int p) 
    {
        int c = 0, ans = 0;
        Array.Sort(a);
        int i = 0, j = a.Length-1;
        if (a.Length == 1) {
            if (p >= a[0]) return 1;
            else return 0;
        }
        while(i <= j)
        {
            if (p >= a[i]) {
                c++;
                p -= a[i++];
                ans = Math.Max(ans, c);
            }
            else if (c > 0)
            {
                c--;
                p += a[j--];
            }
            else break;
        }
        return ans;
    }
}
