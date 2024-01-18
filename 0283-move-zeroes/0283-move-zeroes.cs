public class Solution {
    public void MoveZeroes(int[] a) 
    {
        int j = -1;
        for (int i = 0; i < a.Length; i++) {
            if (a[i] == 0) {
                j = i; break;
            }
        }
        for (int i = 0; i < a.Length; i++) {
            if (j == -1) break;
            if (a[i] != 0 && i > j) {
                int t = a[j];
                a[j] = a[i];
                a[i] = t;
                j++;
                if (j == a.Length) break;
            }
        }
    }
}