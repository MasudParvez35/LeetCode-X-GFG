//{ Driver Code Starts
//Initial template for C++

#include<bits/stdc++.h>
using namespace std;


// } Driver Code Ends
//User function template for C++

class Solution
{
  public:
    long long fun(string s, int k)
    {
        if (k < 0) return 0;
        long long ans = 0, c = 0;
    	vector<int> cnt(26, 0);
    	for (int i = 0, j = 0; i < s.size(); i++)
    	{
    	    cnt[s[i]-'a']++;
    	    if (cnt[s[i]-'a'] == 1) c++;
    	    while(c > k)
    	    {
    	        cnt[s[j]-'a']--;
    	        if (cnt[s[j]-'a'] == 0) c--;
    	        j++;
    	    }
    	    ans += (i-j+1);
    	}
    	return ans;
    }
    long long int substrCount (string s, int k) 
    {
    	return fun(s,k) - fun(s,k-1);
    }
};

//{ Driver Code Starts.


int main()
{
    int t; cin >> t;
    while (t--)
	{
		string s; cin >> s;
		int k; cin >> k;
		Solution ob;
		cout <<ob.substrCount (s, k) << endl;
	}
}
// } Driver Code Ends