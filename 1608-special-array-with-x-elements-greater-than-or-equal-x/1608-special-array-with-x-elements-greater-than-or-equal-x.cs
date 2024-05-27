public class Solution {
    public int SpecialArray(int[] a) 
    {
        Array.Sort(a);
        int l = 1, r = 1000, ans = -1;
        while(l <= r)
        {
            int mid = (l+r)/2, c = 0;
            foreach(int i in a) {
                if (i >= mid) c++;
            }
            if (c >= mid) {
                if (c == mid) ans = mid;
                l = mid+1;
            }
            else r = mid-1;
        }
        return ans;
    }
}