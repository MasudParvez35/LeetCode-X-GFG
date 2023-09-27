//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;


// } Driver Code Ends
//User function teamplate for C++

class Solution{
  public:
    int Up(int b[], int m, int val, int x)
    {
        int l = 0, r = m-1, ans = -1;
        while(l <= r)
        {
            int mid = (l+r)/2;
            if (val + b[mid] >= x) {
                ans = mid;
                r = mid-1;
            }
            else l = mid+1;
        }
        return ans;
    }
    int Low(int b[], int m, int val, int x)
    {
        int l = 0, r = m-1, ans = -1;
        while(l <= r)
        {
            int mid = (l+r)/2;
            if (val + b[mid] < x) {
                ans = mid;
                l = mid+1;
            }
            else r = mid-1;
        }
        return ans;
    }
    vector<int> printClosest(int a[], int b[], int n, int m, int X) 
    {
        vector<int> v;
        int x = 0, y = 0, mi = INT_MAX;
        for (int i = 0; i < n; i++)
        {
            int up = Up(b,m,a[i],X);
            int low = Low(b,m,a[i],X);
            if (up != -1) {
                int p = abs(X - (a[i]+b[up]));
                if (mi > p) {
                    mi = p;
                    x = a[i]; y = b[up];
                }
            }
            if (low != -1) {
                int p = abs(X - (a[i]+b[low]));
                if (mi > p) {
                    mi = p;
                    x = a[i]; y = b[low];
                }
            }
        }
        v.push_back(x); 
        v.push_back(y);
        return v;
    }
};

//{ Driver Code Starts.

int main()
{
	int t;
	cin>>t;
	int m,n,x;
	while(t--)
    {
        cin>>n>>m;
        int a[n],b[m];
        
        for(int i=0;i<n;i++)
            cin>>a[i];
            
        for(int i=0;i<m;i++)
            cin>>b[i];
            
        cin>>x;
        
        vector<int> ans;
        Solution ob;
        ans = ob.printClosest(a, b, n, m, x);
        cout << abs(ans[0] + ans[1] - x) << endl;
        
    }
    return 0;
}

// } Driver Code Ends