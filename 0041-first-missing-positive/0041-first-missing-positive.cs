public class Solution {
    public int FirstMissingPositive(int[] a) 
    {
        HashSet<int> st = new HashSet<int>();
        foreach (int i in a) st.Add(i);
        for (int i = 1; i <= 100005; i++) {
            if (!st.Contains(i)) return i;
        }
        return -1;
    }
}
