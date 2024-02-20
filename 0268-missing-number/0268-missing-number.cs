public class Solution {
    public int MissingNumber(int[] a) 
    {
        int n = a.Length;
        int x = (n*(n+1))/2, sm = 0;
        foreach (int i in a) sm += i;
        return x - sm;
    }
}