public class Solution {
    public long LargestPerimeter(int[] a) 
    {
        Array.Sort(a, (x,y) => {
           return y-x; 
        });
        long sm = 0;
        foreach (int i in a) sm += i;
        foreach (int i in a) {
            sm -= i;
            if (sm > i) return sm+i;
        }
        return -1;
    }
}
