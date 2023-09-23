//{ Driver Code Starts
#include <bits/stdc++.h>
using namespace std;

struct Item{
    int value;
    int weight;
};


// } Driver Code Ends
//class implemented
class Solution
{
    public:
    //Function to get the maximum total value in the knapsack.
    double fractionalKnapsack(int W, Item arr[], int n)
    {
        double ans = 0;
        vector<pair<double,pair<int,int>>>vp;
        for(int i = 0 ; i < n ; ++i){
            int v = arr[i].value;
            int w = arr[i].weight;
            vp.push_back({double(v*1.0/w*1.0),{v,w}});
        }
        //sort(vp.begin(),vp.end(),greater<pair<double,pair<int,int>>>());
        sort(vp.rbegin(),vp.rend());
        for(int i = 0 ; i < n ; ++i)
        {
            if(W>=vp[i].second.second){
                ans+=vp[i].second.first;
                W-=vp[i].second.second;
            }
            else{
            ans = ans + ((W/(double)vp[i].second.second))*vp[i].second.first;
            break;
            }
        }
        return ans;
    }
        
};


//{ Driver Code Starts.
int main()
{
	int t;
	//taking testcases
	cin>>t;
	cout<<setprecision(2)<<fixed;
	while(t--){
	    //size of array and weight
		int n, W;
		cin>>n>>W;
		
		Item arr[n];
		//value and weight of each item
		for(int i=0;i<n;i++){
			cin>>arr[i].value>>arr[i].weight;
		}
		
		//function call
		Solution ob;
		cout<<ob.fractionalKnapsack(W, arr, n)<<endl;
	}
    return 0;
}
// } Driver Code Ends