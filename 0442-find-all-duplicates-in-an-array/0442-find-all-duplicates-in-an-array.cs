public class Solution {
    public IList<int> FindDuplicates(int[] a) 
    {
        List<int> ans = new List<int>();
        Array.Sort(a, (x,y) => {
            return x-y;
        });
        for (int i = 1; i < a.Length; i++) {
            if (a[i] == a[i-1]) ans.Add(a[i]);
        }
        return ans;
    }
}