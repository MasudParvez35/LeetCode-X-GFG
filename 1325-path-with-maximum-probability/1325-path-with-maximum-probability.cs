public class Solution {
    public double MaxProbability(int n, int[][] a, double[] b, int s, int t) 
    {
        var adj = new List<KeyValuePair<int, double>>[n+1];
        for (int i = 0; i <= n; i++)
        {
            adj[i] = new List<KeyValuePair<int,double>>();
        }
        for (int i = 0; i < a.Length; i++)
        {
            adj[a[i][0]].Add(new KeyValuePair<int, double>(a[i][1], b[i]));
            adj[a[i][1]].Add(new KeyValuePair<int, double>(a[i][0], b[i]));
        }

        double[] dist = new double[n+1];
        Queue <int> q = new Queue<int>();
        q.Enqueue(s);
        dist[s] = 1.0;
        
        while(q.Count() > 0)
        {
            int node = q.Dequeue();
            foreach (var it in adj[node])
            {
                int child = it.Key;
                double d = it.Value;
                double total = dist[node]*d;
                if (total > dist[child])
                {
                    dist[child] = total;
                    q.Enqueue(child);
                }
            }
        }

        return dist[t];
    }
}