//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
class Solution{
		

	public:
	int maxSumIS(int a[], int n)  
	{  
	    vector <int> dp(n+1);
	    for (int i = 0; i < n; i++) dp[i] = a[i];
	    for (int i = 1; i < n; i++) {
	        for (int j = 0; j < i; j++) {
	            if (a[i] > a[j]) {
	                dp[i] = max(dp[i], a[i]+dp[j]);
	            }
	        }
	    }
	    return *max_element(begin(dp), end(dp));
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
	    cout << ob.maxSumIS(a, n) << "\n";
	     
    }
    return 0;
}


// } Driver Code Ends