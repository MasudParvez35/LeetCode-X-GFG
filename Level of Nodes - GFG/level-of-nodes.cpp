//{ Driver Code Starts
#include<bits/stdc++.h>
using namespace std;

// } Driver Code Ends

class Solution
{
	public:
	void dfs(int node, vector<int> adj[], vector <int>&dist, vector <int>&vis)
	{
	    vis[node] = 1;
	    for (int child : adj[node]) {
	        if (!vis[child]) {
	            dist[child] = dist[node]+1;
	            dfs(child,adj,dist,vis);
	        }
	    }
	}
	int nodeLevel(int n, vector<int> adj[], int x) 
	{
	    vector <int> dist(n+1), vis(n+1);
	    dfs(0,adj,dist,vis);
	    if (x == 0) return 0;
	    if (dist[x] == 0) return -1;
	    else return dist[x];
	}
};

//{ Driver Code Starts.


int main()
{
    
    int t;
    cin >> t;
    while(t--)
    {
    	int V, E, X;
    	cin >> V >> E;

    	vector<int> adj[V];

    	for(int i = 0; i < E; i++)
    	{
    		int u, v;
    		cin >> u >> v;
    		adj[u].push_back(v);
    		adj[v].push_back(u);
    	}
    	cin>>X;

    	Solution obj;
    	cout << obj.nodeLevel(V, adj, X) << "\n";
    }

    return 0;
}


// } Driver Code Ends