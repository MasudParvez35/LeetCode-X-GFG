public class Solution {
    public int FindDuplicate(int[] a) 
    {
        Array.Sort(a, (x,y) => {
            return x-y;
        });
        for (int i = 1; i < a.Length; i++) {
            if (a[i] == a[i-1]) return a[i];
        }
        return -1;
    }
}