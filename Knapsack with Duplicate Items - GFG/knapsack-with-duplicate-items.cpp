//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
// User function Template for C++

class Solution{
public:
    int dfs(int val[], int wt[], int i, int w, vector<vector<int>>&dp)
    {
        if (i < 0 or w <= 0) return 0;
        if (dp[i][w] != -1) return dp[i][w];
        if (wt[i] <= w) {
            int take = val[i] + dfs(val,wt,i,w-wt[i],dp);
            int ntake = dfs(val,wt,i-1,w,dp);
            return dp[i][w] = max(take,ntake);
        }
        else return dp[i][w] = dfs(val,wt,i-1,w,dp);
    }
    int knapSack(int n, int w, int val[], int wt[])
    {
        vector<vector<int>> dp(n+1, vector<int>(w+1,-1));
        return dfs(val,wt,n-1,w,dp);
    }
};

//{ Driver Code Starts.

int main(){
    int t;
    cin>>t;
    while(t--){
        int N, W;
        cin>>N>>W;
        int val[N], wt[N];
        for(int i = 0;i < N;i++)
            cin>>val[i];
        for(int i = 0;i < N;i++)
            cin>>wt[i];
        
        Solution ob;
        cout<<ob.knapSack(N, W, val, wt)<<endl;
    }
    return 0;
}
// } Driver Code Ends