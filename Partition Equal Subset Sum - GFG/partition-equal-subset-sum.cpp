//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
// User function Template for C++

class Solution{
public:
    bool solve(int a[], int i, int sm, int n, vector<vector<int>>&dp)
    {
        if (i >= n) {
            if (sm == 0) return 1;
            else return 0;
        }
        if (sm < 0) return 0;
        if (dp[i][sm] != -1) return dp[i][sm];
        int t = solve(a,i+1,sm-a[i],n,dp);
        int nt = solve(a,i+1,sm,n,dp);
        return dp[i][sm] = t | nt;
    }
    int equalPartition(int n, int a[])
    {
        int sm = 0;
        for (int i = 0; i < n; i++) sm += a[i];
        if (sm % 2) return 0;
        sm /= 2;
        vector<vector<int>> dp(n+1, vector<int>(sm+1,-1));
        return solve(a,0,sm,n,dp);
    }
};

//{ Driver Code Starts.

int main(){
    int t;
    cin>>t;
    while(t--){
        int N;
        cin>>N;
        int arr[N];
        for(int i = 0;i < N;i++)
            cin>>arr[i];
        
        Solution ob;
        if(ob.equalPartition(N, arr))
            cout<<"YES\n";
        else
            cout<<"NO\n";
    }
    return 0;
}
// } Driver Code Ends