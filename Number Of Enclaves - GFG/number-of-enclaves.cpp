//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;


// } Driver Code Ends
// User function Template for C++

class Solution {
  public:
    int dx[5] = {1,-1,0,0};
    int dy[5] = {0,0,1,-1};
    int n, m, ans = 0, c = 0, f = 0;
    void dfs(vector<vector<int>>&a, int i, int j, vector<vector<int>>&vis)
    {
        if (!i or !j or i == n-1 or j == m-1) f = 1;
        c++;
        //cout << i << " " << j << " " << c << " " << f << endl;
        vis[i][j] = 1;
        for (int k = 0; k < 4; k++) 
        {
            int x = dx[k]+i, y = dy[k]+j;
            if (x < n and y < m and x >= 0 and y >= 0 and a[x][y] and !vis[x][y]) 
            {
                dfs(a,x,y,vis);
            }
        }
    }
    int numberOfEnclaves(vector<vector<int>> &a) 
    {
        n = a.size(), m = a[0].size();
        vector<vector<int>> vis(n+5, vector<int>(m+5, 0));
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (a[i][j] and !vis[i][j])
                {
                    dfs(a,i,j,vis);
                    //cout << c << endl;
                    if (!f) {
                        ans += c;
                    }
                    c = 0;
                    f = 0;
                }
            }
        }
        return ans;
    }
};


//{ Driver Code Starts.

int main() {
    int t;
    cin >> t;
    while (t--) {
        int n, m;
        cin >> n >> m;
        vector<vector<int>> grid(n, vector<int>(m));
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                cin >> grid[i][j];
            }
        }
        Solution obj;
        cout << obj.numberOfEnclaves(grid) << endl;
    }
}
// } Driver Code Ends