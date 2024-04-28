class Solution {
public:
    vector <int> ar[50005];
    int dist[50005], subT[50005], N;
    vector <int> ans;
    void dfs(int node, int par)
    {
        subT[node] = 1;
        for (auto child : ar[node])
        {
            if (child == par) continue;
            dist[child] += dist[node]+1;
            dfs(child,node);
            subT[node] += subT[child];
        }
    }
    void DFS(int node, int par)
    {
        for (auto child : ar[node])
        {
            if (child == par) continue;
            ans[child] = ans[node] - subT[child] + (N - subT[child]);
            DFS(child,node);
        }
    }
    vector<int> sumOfDistancesInTree(int n, vector<vector<int>>& a)
    {
        N = n;
        ans.resize(n,0);
        for (int i = 0; i < a.size(); i++) {
            int u = a[i][0], v = a[i][1];
            ar[u].push_back(v);
            ar[v].push_back(u);
        }
        dfs(0,-1);
        for (int i = 0; i < n; i++)
        {
            ans[0] += dist[i];
            //cout << dist[i] << " " << subT[i] << endl;
        }
        DFS(0,-1);
        return ans;
    }
};