//{ Driver Code Starts
#include<bits/stdc++.h>
using namespace std;


// } Driver Code Ends
class Solution
{
    public:
    int dfs(int w, int wt[], int val[], int i, vector<vector<int>>&dp)
    {
        if (i < 0 or w <= 0) return 0;
        if (dp[i][w] != -1) return dp[i][w];
        int take = 0, ntake = 0;
        if (wt[i] <= w) {
            ntake = dfs(w,wt,val,i-1,dp);
            take = val[i] + dfs(w-wt[i],wt,val,i-1,dp);
            return dp[i][w] = max(take, ntake);
        }
        else return dp[i][w] = dfs(w,wt,val,i-1,dp);
    }
    int knapSack(int w, int wt[], int val[], int n) 
    { 
        vector<vector<int>> dp(n+1, vector<int>(w+1,-1));
        return dfs(w,wt,val,n-1,dp);
    }
};

//{ Driver Code Starts.

int main()
 {
    //taking total testcases
    int t;
    cin>>t;
    while(t--)
    {
        //reading number of elements and weight
        int n, w;
        cin>>n>>w;
        
        int val[n];
        int wt[n];
        
        //inserting the values
        for(int i=0;i<n;i++)
            cin>>val[i];
        
        //inserting the weights
        for(int i=0;i<n;i++)
            cin>>wt[i];
        Solution ob;
        //calling method knapSack()
        cout<<ob.knapSack(w, wt, val, n)<<endl;
        
    }
	return 0;
}
// } Driver Code Ends