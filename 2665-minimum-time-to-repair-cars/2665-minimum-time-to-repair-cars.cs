public class Solution {
    public long RepairCars(int[] ranks, int cars) 
    {
        long ans = long.MaxValue;
        long left = 1, right = long.MaxValue;
        while(left <= right)
        {
            long mid = (left + right) / 2, count = 0;
            for (int ind = 0; ind < ranks.Length; ind++)
            {
                long x = (long)Math.Sqrt(mid/(double)ranks[ind]);
                count += x;
            }
            if (count >= cars)
            {
                ans = mid;
                right = mid - 1;
            }
            else 
                left = mid + 1;
        }
        
        return ans;
    }
}