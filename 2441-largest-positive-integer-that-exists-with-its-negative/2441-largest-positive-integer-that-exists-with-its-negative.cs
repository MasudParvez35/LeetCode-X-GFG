public class Solution {
    public int FindMaxK(int[] a) 
    {
        Array.Sort(a);
        int i = 0, j = a.Length-1;
        while(i < j)
        {
            int x = a[i]*-1;
            if (x == a[j]) return a[j];
            if (x < a[j]) j--;
            else i++;
        }
        return -1;
    }
}
