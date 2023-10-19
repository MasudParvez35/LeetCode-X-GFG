//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var ip = Console.ReadLine().Trim().Split(' ');
                int V = int.Parse(ip[0]);
                int E = int.Parse(ip[1]);
                List<List<int>> adj = new List<List<int>>();
                for (int i = 0; i < V; i++)
                {
                    adj.Add(new List<int>());
                }
                for (int i = 0; i < E; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    adj[u].Add(v);
                    adj[v].Add(u);
                }
                int X = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                var res = obj.nodeLevel(V, adj, X);
                Console.WriteLine(res);
            }
        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
    public void dfs(int node, List<List<int>> adj, int[] dist, int[] vis)
	{
	    vis[node] = 1;
        foreach (int child in adj[node])
        {
            if (vis[child] == 0)
            {
                dist[child] = dist[node] + 1;
                dfs(child, adj, dist, vis);
            }
        }
	}
    public int nodeLevel(int n, List<List<int>> adj, int x)
    {
        int[] dist = new int[n+1];
        int[] vis = new int[n+1];

        dfs(0, adj, dist, vis);

        if (x == 0) return 0;
        if (dist[x] == 0) return -1;
        return dist[x];
    }
}