class Solution {
public:
    int dx[3] = {-1, 0, 1}, n, m;
    int dy[3] = {1, 1, 1}, mx = 0;
    bool isok(vector<vector<int>>&vis, int i, int j) 
    {
        if (i >= 0 and j >= 0 and i < n and j < m and !vis[i][j])
            return true;
        else return false;
    }
    void dfs(vector<vector<int>>&vis, vector<vector<int>>&a, int i, int j, int c)
    {
        vis[i][j] = 1;
        mx = max(mx, c);
        for (int k = 0; k < 3; k++)
        {
            int nx = i+dx[k], ny = j+dy[k];
            if (isok(vis, nx, ny) and a[nx][ny] > a[i][j]) {
                dfs(vis, a,nx,ny,c+1);
            }
        }
    }
    int maxMoves(vector<vector<int>>& a) 
    {
        n = a.size(), m = a[0].size();
        vector<vector<int>> vis(n+5, vector<int>(m+5));
        for (int i = 0; i < n; i++) {
            dfs(vis,a,i,0,0);
        }
        return mx;
    }
};