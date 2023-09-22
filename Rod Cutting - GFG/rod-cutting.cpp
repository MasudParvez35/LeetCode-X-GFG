//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;


// } Driver Code Ends
// User function Template for C++

class Solution{
  public:
    int solve(int a[], int i, int sm, vector<vector<int>> &dp)
    {
        if (sm == 0 or i < 0) return 0;
        //if (i < 0 or sm < 0) return INT_MIN;
        if (dp[i][sm] != -1) return dp[i][sm];
        int take = INT_MIN;
        if (i+1 <= sm) take = take = a[i] + solve(a,i,sm-(i+1),dp);
        //int take = take = a[i] + solve(a,i,sm-(i+1),dp);
        int ntake = solve(a,i-1,sm,dp);
        return dp[i][sm] = max(take, ntake);
    }
    int cutRod(int a[], int n) 
    {
        vector<vector<int>> dp(n+1,vector<int>(n+1,-1));
        return solve(a,n-1,n,dp);
    }
};

//{ Driver Code Starts.

int main() {
    int t;
    cin >> t;
    while (t--) {
        int n;
        cin >> n;
        int a[n];
        for (int i = 0; i < n; i++) 
            cin >> a[i];
            
        Solution ob;

        cout << ob.cutRod(a, n) << endl;
    }
    return 0;
}
// } Driver Code Ends