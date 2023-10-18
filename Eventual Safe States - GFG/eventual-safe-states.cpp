//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;


// } Driver Code Ends
// User function Template for C++

class Solution {
  public:
    vector<int> eventualSafeNodes(int n, vector<int> adj[]) 
    {
        queue <int> q;
        vector <int> ar[n+5], in(n+1), ans;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < adj[i].size(); j++) {
                ar[adj[i][j]].push_back(i);
                //in[adj[i][j]]++;
                in[i]++;
            }
        }
        for (int i = 0; i < n; i++) {
            if (in[i] == 0) {
                ans.push_back(i);
                q.push(i);
            }
        }
        while(q.size())
        {
            int node = q.front();
            q.pop();
            for (int child : ar[node])
            {
                in[child]--;
                if (in[child] == 0) {
                    ans.push_back(child);
                    q.push(child);
                }
            }
        }
        sort(ans.begin(),ans.end());
        return ans;
    }
};


//{ Driver Code Starts.

int main() {
    int t;
    cin >> t;
    while (t--) {

        int V, E;
        cin >> V >> E;
        vector<int> adj[V];

        for (int i = 0; i < E; i++) {
            int u, v;
            cin >> u >> v;
            adj[u].push_back(v);
        }

        Solution obj;
        vector<int> safeNodes = obj.eventualSafeNodes(V, adj);
        for (auto i : safeNodes) {
            cout << i << " ";
        }
        cout << endl;
    }
}

// } Driver Code Ends