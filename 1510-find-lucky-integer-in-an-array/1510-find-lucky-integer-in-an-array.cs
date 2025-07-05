public class Solution {
    public int FindLucky(int[] arr) 
    {
        var fre = new Dictionary<int,int>();
        int ans = -1;
        foreach (int item in arr)
        {
            if (!fre.ContainsKey(item))
                fre[item] = 1;
            else
                fre[item]++;
        }
        foreach (var item in fre)
        {
            var key = item.Key;
            var value = item.Value;
            if (key == value)
                ans = Math.Max(ans, key);
        }
        return ans;
    }
}