class Solution {
public:
    int maxSumDivThree(vector<int>& a) 
    {
        int sm = 0;
        vector<pair<int,int>> vp1, vp2;
        for (int i = 0; i < a.size(); i++) {
            sm += a[i];
            if (a[i]%3 == 1) vp1.push_back({a[i]%3, a[i]});
            if (a[i]%3 == 2) vp2.push_back({a[i]%3, a[i]});
        }
        vp1.push_back({1,1e5});
        vp1.push_back({1,1e5});
        vp2.push_back({2,1e5});
        vp2.push_back({2,1e5});
        sort(vp1.begin(),vp1.end());
        sort(vp2.begin(),vp2.end());
        int x = sm%3;
        cout << x << endl;
        if (x == 1)
        {
            int x = vp1[0].second;
            int y = vp2[0].second + vp2[1].second;
            sm -= min(x,y);
        }
        else if (x == 2)
        {
            int x = vp2[0].second;
            int y = vp1[0].second + vp1[1].second;
            sm -= min (x,y);
        }
        return sm;
    }
};
