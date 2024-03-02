public class Solution {
    public int[] SortedSquares(int[] a) 
    {
        for (int i = 0; i < a.Length; i++) {
            a[i] = a[i]*a[i];
        }
        Array.Sort(a);
        return a;
    }
}