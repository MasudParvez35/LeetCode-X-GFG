public class Solution {
    public int[] RearrangeArray(int[] a) 
    {
        int n = a.Length, ind = 0;
        int[] ans = new int[n];
        for (int i = 0, j = 0; i < n; i++)
        {
            if (a[i] >= 0)
            {
                ans[ind++] = a[i];
                while(j < n)
                {
                    if (a[j] < 0)
                    {
                        ans[ind++] = a[j++];
                        break;
                    }
                    j++;
                }
            }
        }
        return ans;
    }
}