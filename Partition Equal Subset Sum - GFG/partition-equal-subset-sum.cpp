//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
// User function Template for C++

class Solution{
public:
    bool dfs(int a[], int n, int i, int sm, vector<vector<int> >&dp)
    {
        if (sm == 0) return 1;
        if (sm < 0) return 0;
        if (i == n) {
            return sm == 0;
        }
        if (dp[i][sm] != -1) return dp[i][sm];
        int ntake = dfs(a,n,i+1,sm,dp), take = 0;
        if (a[i] <= sm) {
            take = dfs(a,n,i+1,sm-a[i],dp);
        }
        return dp[i][sm] = take | ntake;
    }
    int equalPartition(int n, int a[])
    {
        int sm = 0;
        for (int i = 0; i < n; i++) sm += a[i];
        if (sm % 2) return false;
        sm /= 2;
        vector<vector<int>> dp(n+1, vector<int>(sm+1, -1));
        return dfs(a,n,0,sm,dp);
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