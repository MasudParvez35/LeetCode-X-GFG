//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
#include <bits/stdc++.h>
using namespace std;
//Position this line where user code will be pasted.

class Solution{
	public:
	int dfs(int c[], int i, int w, vector<vector<int>>&dp)
	{
	    if (w == 0) return 0;
	    if (i < 0 or w < 0) return 1e9;
	    if (dp[i][w] != -1) return dp[i][w];
	    int ntake = dfs(c,i-1,w,dp), take = 1e9;
	    if (i+1 <= w and c[i] != -1) take = c[i] + dfs(c,i,w-(i+1),dp);
	    return dp[i][w] = min(take, ntake);
	}
	int minimumCost(int c[], int n, int w) 
	{ 
	    vector<vector<int>> dp(n+1, vector<int>(w+1,-1));
        int ans = dfs(c,n-1,w,dp);
        return ans == 1e9 ? -1 : ans;
	} 
};


//{ Driver Code Starts.
int main() 
{
   	
   
   	int t;
    cin >> t;
    while (t--)
    {
        int n, w;
        cin >> n >> w;

        int a[n];

        for(int i = 0; i < n; i++)
        	cin >> a[i];

       

	    Solution ob;
	    cout << ob.minimumCost(a, n, w) << "\n";
	     
    }
    return 0;
}
// } Driver Code Ends