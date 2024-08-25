class Solution {
public:
    vector<int> getFinalState(vector<int>& a, int k, int m) 
    {
        priority_queue<pair<int,int>, vector<pair<int,int>>,
        greater<pair<int,int>>> pq;

        vector<pair<int,int>> vp;
        for (int i = 0; i < a.size(); i++) {
            pq.push({a[i], i});
        }
        for (int i = 0; i < k; i++)
        {
            auto x = pq.top();
            pq.pop();
            int val = x.first, ind = x.second;
            pq.push({m*val, ind});
        }
        while(!pq.empty())
        {
            auto x = pq.top();
            pq.pop();
            int val = x.first, ind = x.second;
            vp.push_back({ind, val});
        }
        sort(vp.begin(), vp.end());
        vector <int> ans;
        for (int i = 0; i < vp.size(); i++) {
            ans.push_back(vp[i].second);
        }
        return ans;
    }
};