public class Solution {
    public int[] DailyTemperatures(int[] a) 
    {
        int n = a.Length;
        int[] ans = new int[n];
        Stack <int> st = new Stack<int>();
        for (int i = n-1; i >= 0; i--)
        {
            while (st.Count() > 0 && a[i] >= a[st.Peek()])
            {
                st.Pop();
            }
            if (st.Count() > 0 && a[i] < a[st.Peek()]) 
                ans[i] = st.Peek() - i;
            st.Push(i);
        }
        return ans;
    }
}