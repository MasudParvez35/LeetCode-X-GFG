public class Solution {
    public int MinOperations(int[] a, int k) 
    {
        int ans = 0;
        PriorityQueue<long, long> Q = new PriorityQueue<long, long>();
        foreach (int i in a)
            Q.Enqueue(i, i);

        while(Q.Count > 1)
        {
            long first = Q.Peek();
            Q.Dequeue();

            if (first >= k)
                break;
            long second = Q.Peek();
            Q.Dequeue();
            long newNumber = 2*first + second;
            Q.Enqueue(newNumber, newNumber);
            ans++;
        }

        return ans;
    }
}