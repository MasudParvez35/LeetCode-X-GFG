class Solution {
public:
    int n, m, sv, ev, vis[1000+35], par[1000+35];
    vector<int> ar[1000+35];
    bool dfs(int node, int p) {
        vis[node] = 1;
        par[node] = p;
        for (auto child : ar[node]) {
            if (child == p) continue;
            if (vis[child]) {
                sv = child, ev = node;
                return true;
            }
            if (!vis[child]) {
                int f = dfs(child,node);
                if (f) return true;
            }
        }
        return false;
    }
    vector<int> findRedundantConnection(vector<vector<int>>& a) 
    {
        vector<int> v;
        map <int ,int> mp;
        for (int i = 0; i < a.size(); i++)
        {
            int x = a[i][0], y = a[i][1];
            ar[x].push_back(y);
            ar[y].push_back(x);
        }
        dfs(1,-1);
        
        mp[ev]++;
        while(sv != ev)
        {
            mp[par[ev]]++;
            ev = par[ev];
        }
        for (int i = a.size()-1; i >= 0; i--)
        {
            int x = a[i][0], y = a[i][1];
            if (mp[x] and mp[y]) {
                v.push_back(x); 
                v.push_back(y); 
                break;
            }
        }
        return v;
    }
};