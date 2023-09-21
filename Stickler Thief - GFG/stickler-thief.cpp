//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;
typedef long long int ll;

// } Driver Code Ends
class Solution
{
    public:
    int dfs(int a[], int i, vector<int>&dp)
    {
        if (i < 0) return 0;
        if (dp[i] != -1) return dp[i];
        int ntake = dfs(a,i-1,dp);
        int take = a[i] + dfs(a,i-2,dp);
        return dp[i] = max(take,ntake);
    }
    int FindMaxSum(int a[], int n)
    {
        vector <int> dp(n+1,-1);
        return dfs(a,n-1,dp);
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
	    //taking number of houses
		int n;
		cin>>n;
		int a[n];
		
		//inserting money of each house in the array
		for(int i=0;i<n;++i)
			cin>>a[i];
		Solution ob;
		//calling function FindMaxSum()
		cout<<ob.FindMaxSum(a,n)<<endl;
	}
	return 0;
}

// } Driver Code Ends