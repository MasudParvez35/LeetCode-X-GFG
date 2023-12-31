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
            double x = double((v*1.0)/(w*1.0));
            vp.push_back({x,{v,w}});
        }
        //sort(vp.rbegin(),vp.rend());
        sort(vp.begin(),vp.end(),greater<pair<double,pair<int,int>>>());
        for(int i = 0 ; i < n ; ++i)
        {
            if(W>=vp[i].second.second) {
                ans+=vp[i].second.first;
                W-=vp[i].second.second;
            }
            else
            {
                //ans += ((W/(double)vp[i].second.second))*vp[i].second.first;
                ans += vp[i].first * W;
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