//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
// User function Template for C++

class Solution{
public:
    vector<pair<int,int>> vp;
    int dx[4] = {1,-1,0,0};
    int dy[4] = {0,0,1,-1};
    void dfs(int i, int j, vector<vector<char>>&s, vector<vector<int>> &vis, int n, int m)
    {
        vp.push_back({i,j});
        vis[i][j] = 1;
        for (int k = 0; k < 4; k++)
        {
            int x = i+dx[k], y = j+dy[k];
            if (x >= 0 and y >= 0 and x < n and y < m and !vis[x][y] and s[x][y] == 'O') {
                dfs(x,y,s,vis,n,m);
            }
        }
    }
    vector<vector<char>> fill(int n, int m, vector<vector<char>> s)
    {
        vector<vector<int>> vis(n+1, vector<int>(m+1, 0)); 
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (s[i][j] == 'O' and !vis[i][j]) 
                {
                    dfs(i,j,s,vis,n,m);
                    bool ok = true;
                    for (auto it : vp) {
                        //cout << it.first << " " << it.second << endl;
                        int x = it.first, y = it.second;
                        if(!x or !y or x == n-1 or y == m-1) ok = false;
                    }
                    if (ok) {
                        for (auto it : vp) {
                            s[it.first][it.second] = 'X';
                        }
                    }
                    //cout << endl;
                    vp.clear();
                }
            }
        }
        return s;
    }
};

//{ Driver Code Starts.

int main(){
    int t;
    cin>>t;
    while(t--){
        int n, m;
        cin>>n>>m;
        vector<vector<char>> mat(n, vector<char>(m, '.'));
        for(int i = 0;i < n;i++)
            for(int j=0; j<m; j++)
                cin>>mat[i][j];
        
        Solution ob;
        vector<vector<char>> ans = ob.fill(n, m, mat);
        for(int i = 0;i < n;i++) {
            for(int j = 0;j < m;j++) {
                cout<<ans[i][j]<<" ";
            }
            cout<<"\n";
        }
    }
    return 0;
}
// } Driver Code Ends