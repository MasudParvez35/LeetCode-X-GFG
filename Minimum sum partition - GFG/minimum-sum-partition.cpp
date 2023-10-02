//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
class Solution{
  public:
    // int dfs(int a[], int n, int i, int sm, vector<vector<int>>&dp)
    // {
    //     if (sm == 0) return 0;
    //     if (i < 0) return sm;
    //     if (dp[i][sm] != -1) return dp[i][sm];
    //     int ntake = dfs(a,n,i-1,sm,dp), take = 1e9;
    //     if (a[i] <= sm) {
    //         take = dfs(a,n,i-1,sm+a[i],dp);
    //     }
    //     return dp[i][sm] = min(take, ntake);
    // }
    int dfs(int a[], int n, int i, int sm, int t, vector<vector<int>>&dp)
    {
        if (sm == t) return sm;
        if (i < 0) return sm;
        if (dp[i][sm] != -1) return dp[i][sm];
        int ntake = dfs(a,n,i-1,sm,t,dp), take = 0;
        if (sm+a[i] <= t) {
            take = dfs(a,n,i-1,sm+a[i],t,dp);
        }
        return dp[i][sm] = max(take, ntake);
    }
	int minDifference(int a[], int n) 
	{ 
	    long sm = 0;
	    for (int i = 0; i < n; i++) sm += a[i];
	    int x = (sm+1)/2;
	    vector<vector<int>> dp(n+1, vector<int>(x+1,-1));
	    int p = dfs(a,n,n-1,0,x,dp);
	    return abs(sm - 2*p);
	} 
};


//{ Driver Code Starts.
int main() 
{
   
   
   	int t;
    cin >> t;
    while (t--)
    {
        int n;
        cin >> n;

        int a[n];
        for(int i = 0; i < n; i++)
        	cin >> a[i];

       

	    Solution ob;
	    cout << ob.minDifference(a, n) << "\n";
	     
    }
    return 0;
}
// } Driver Code Ends