public class Solution {
    public int MajorityElement(int[] a) 
    {
        Array.Sort(a);
        return a[a.Length/2];
    }
}