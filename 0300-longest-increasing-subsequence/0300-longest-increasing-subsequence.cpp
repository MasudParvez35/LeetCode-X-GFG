class Solution {
public:
    int LIS(vector<int>&a)
    {
        vector<int> v;
        v.push_back(a[0]);
        for (int i = 1; i < a.size(); i++)
        {
            if (a[i] > v.back()) v.push_back(a[i]);
            else {
                auto it = lower_bound(v.begin(),v.end(),a[i])-v.begin();
                v[it] = a[i];
            }
        }
        return v.size();
    }
    int lengthOfLIS(vector<int>& a) 
    {
        return LIS(a);
    }
};