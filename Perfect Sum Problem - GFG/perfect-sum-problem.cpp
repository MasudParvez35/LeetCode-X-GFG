//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
class Solution{

	public:
	int mod = 1e9+7;
	int solve(int a[], int i, int sum, int &n, vector<vector<int>>&dp)
	{
	    if (i >= n) {
	        if(sum == 0) return 1;
             return 0;
	    }
	    //if (sum == 0) return 1;
	    if (sum < 0) return 0;
	    if (dp[i][sum] != -1) return dp[i][sum];
	    int take = solve(a, i+1, sum-a[i], n, dp)%mod;
	    int ntake = solve(a, i+1, sum, n, dp)%mod;
	    return dp[i][sum] = (take + ntake)%mod;
	}
	int perfectSum(int a[], int n, int sum)
	{
        vector<vector<int>> dp(n+1, vector<int>(sum+1, -1));
        return solve(a, 0, sum, n, dp);
	}
	  
};

//{ Driver Code Starts.
int main() 
{
   	
   
   	int t;
    cin >> t;
    while (t--)
    {
        int n, sum;

        cin >> n >> sum;

        int a[n];
        for(int i = 0; i < n; i++)
        	cin >> a[i];

       

	    Solution ob;
	    cout << ob.perfectSum(a, n, sum) << "\n";
	     
    }
    return 0;
}

// } Driver Code Ends