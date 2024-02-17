public class Solution {
    public int FurthestBuilding(int[] h, int b, int x) 
    {
        int ans = 0, l = 0, r = h.Length-1;
        while(l <= r)
        {
            int mid = (l+r)/2;
            List <int> v = new List<int>();
            for (int i = 0; i < mid; i++) {
                if (h[i] < h[i+1]) v.Add(h[i+1] - h[i]);
            }
            v.Sort((x,y) => {
                return y-x;
            });
            int sm = 0, ok = 1;
            for (int i = x; i < v.Count(); i++) {
                sm += v[i];
                if (sm > b) ok = 0;
            }
            if (ok == 1) {
                ans = mid;
                l = mid+1;
            }
            else r = mid-1;
        }
        return ans;
    }
}
