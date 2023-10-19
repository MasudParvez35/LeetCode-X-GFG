//{ Driver Code Starts
#include<bits/stdc++.h>
using namespace std;

// } Driver Code Ends

class Solution
{
	public:
	//Function to find the level of node X.
	int nodeLevel(int n, vector<int> adj[], int x) 
	{
	    vector <int> vis(n+1);
	    queue <int> q;
	    q.push(0);
	    int lev = 0;
	    if (x == 0) return 0;
	    vis[0] = 1;
	    while(q.size())
	    {
	        int len = q.size();
	        for (int i = 0; i < len; i++)
	        {
	            int node = q.front();
	            q.pop();
	            for (int child : adj[node])
	            {
	                if (!vis[child]) {
    	                if (child == x) return lev+1;
    	                q.push(child);
    	                vis[child] = 1;
	                }
	            }
	        }
	        lev++;
	    }
	    return -1;
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