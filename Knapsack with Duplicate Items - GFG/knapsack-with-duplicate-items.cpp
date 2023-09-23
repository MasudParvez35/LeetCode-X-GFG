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
        if (i < 0) return 0;
        if (dp[i][w] != -1) return dp[i][w];
        int ntake = dfs(val,wt,i-1,w,dp), take = 0;
        if (wt[i] <= w) take = val[i] + dfs(val,wt,i,w-wt[i],dp);
        return dp[i][w] = max(take, ntake);
    }
    int knapSack(int N, int W, int val[], int wt[])
    {
        vector <vector<int>> dp(N+1, vector<int>(W+1,-1));
        return dfs(val,wt,N-1,W,dp);
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