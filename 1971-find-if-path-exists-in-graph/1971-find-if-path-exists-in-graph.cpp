class Solution {
public:
    vector <int> ar[200005];
    int vis[200005];
    void dfs(int node) {
        vis[node] = 1;
        for (auto child : ar[node]) {
            if (!vis[child]) {
                dfs(child);
            }
        }
    }
    bool validPath(int n, vector<vector<int>>& a, int s, int d) 
    {
        for (int i = 0; i < a.size(); i++) {
            int u = a[i][0], v = a[i][1];
            ar[u].push_back(v);
            ar[v].push_back(u);
        }
        dfs(s);
        return vis[d] == 1;
    }
};
