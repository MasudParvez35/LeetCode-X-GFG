//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
class Solution{
	public:
	int dp[1001][1001];
    int score(int a[], int l, int r) 
    {
        if (l > r) return 0;
        if (dp[l][r] != -1) return dp[l][r];
        int left = a[l] + min(score(a,l+1,r-1), score(a,l+2,r));
        int right = a[r] + min(score(a,l+1,r-1), score(a,l,r-2));
        return dp[l][r] = max(left, right);
    }
	int maxAmount(int a[], int n)
	{
		memset(dp, -1, sizeof(dp));
        int val = score(a,0,n-1);
        return val;
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
	    cout << ob.maxAmount(a, n) << "\n";

	     
    }
    return 0;
}

// } Driver Code Ends