class Solution {
public:
    int dx[4] = {0, 0, 1, -1};
    int dy[4] = {1, -1, 0, 0};
    int vis[20][20], n, m;
    void dfs(vector<vector<int>>&a, int i, int j, int& sm)
    {
        vis[i][j] = 1;
        sm += a[i][j];
        for (int ii = 0; ii < 4; ii++)
        {
            int nx = i+dx[ii], ny = j+dy[ii];
            if (nx >= 0 and ny >= 0 and nx < n and ny < m and !vis[nx][ny] and a[nx][ny]) {
                dfs(a,nx,ny, sm);
            }
        }
    }
    int findMaxFish(vector<vector<int>>& a) 
    {
        n = a.size(), m = a[0].size();
        int ans = 0;
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i][j] > 0)
                {
                    int sm = 0;
                    dfs(a,i,j, sm);
                    ans = max(ans, sm);
                }
            }
        }
        return ans;
    }
};