public class Solution {
    public int[] PrevPermOpt1(int[] a) 
    {
        int ind = -1;
        for (int i = 0; i < a.Length-1; i++) {
            if (a[i] > a[i+1]) ind = i;
        }
        if (ind == -1) return a;
        for (int i = a.Length-1; i > 0; i--) {
            if (a[i] != a[i-1] && a[ind] > a[i]) {
                int tmp = a[ind];
                a[ind] = a[i];
                a[i] = tmp;
                break;
            }
        }
        return a;
    }
}