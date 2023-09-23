//{ Driver Code Starts
#include <iostream>
using namespace std;


// } Driver Code Ends
class Solution{
    public:
    // Function to find equilibrium point in the array.
    // a: input array
    // n: size of array
    int equilibriumPoint(long long a[], int n) 
    {
        if (n == 1) return 1;
        if (n == 2) return -1;
        int ans = -1;
        long long int pre[n];
        pre[0] = a[0];
        for (int i = 1; i < n; i++) {
            pre[i] = pre[i-1] + a[i];
        }
        //for (int i = 0; i < n; i++) cout << pre[i] << " ";
        for (int i = 1; i < n-1; i++)
        {
            int x = pre[i-1], y = pre[n-1]-pre[i];
            if (x == y) return i+1;
        }
        return -1;
    }
    // 1 4 9 11 13
};

//{ Driver Code Starts.


int main() {

    long long t;
    
    //taking testcases
    cin >> t;

    while (t--) {
        long long n;
        
        //taking input n
        cin >> n;
        long long a[n];

        //adding elements to the array
        for (long long i = 0; i < n; i++) {
            cin >> a[i];
        }
        
        Solution ob;

        //calling equilibriumPoint() function
        cout << ob.equilibriumPoint(a, n) << endl;
    }
    return 0;
}

// } Driver Code Ends