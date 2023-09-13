//{ Driver Code Starts
// Initial Template for C++

#include <bits/stdc++.h>
using namespace std;

// } Driver Code Ends
// User function Template for C++

class Solution{
public:
    string findLargest(int n, int s)
    {
        if (s > n*9 or n > 1 and !s) return "-1";
        string ans = "";
        for (int i = 9; i >= 0; )
        {
            while (s >= i) {
                ans += (i+'0');
                s -= i;
                if (ans.size() == n) return ans;
            }
            i--;
        }
        return ans;
    }
};

//{ Driver Code Starts.

int main(){
    int t;
    cin>>t;
    while(t--){
        int N, S;
        cin>>N>>S;
        
        Solution ob;
        cout<<ob.findLargest(N, S)<<"\n";
    }
    return 0;
}
// } Driver Code Ends