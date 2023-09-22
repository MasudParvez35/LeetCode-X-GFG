//{ Driver Code Starts
#include<bits/stdc++.h>
using namespace std;


// } Driver Code Ends
class Solution
{
    public:
    int solve(int val[], int wt[], int i, int w, vector<vector<int>>&dp)
    {
        if (i < 0) return 0;
        if (dp[i][w] != -1) return dp[i][w];
        int ntake = solve(val,wt,i-1,w,dp), take = 0;
        if (wt[i] <= w) take = val[i] + solve(val,wt,i-1,w-wt[i],dp);
        return dp[i][w] = max(take, ntake);
    }
    int knapSack(int w, int wt[], int val[], int n) 
    { 
        vector<vector<int>> dp(n+1,vector<int>(w+1,-1));
        return solve(val,wt,n-1,w,dp);
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