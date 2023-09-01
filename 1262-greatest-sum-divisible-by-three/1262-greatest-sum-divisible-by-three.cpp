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
        sort(vp1.begin(),vp1.end());
        sort(vp2.begin(),vp2.end());
        int x = sm%3;
        cout << x << endl;
        if (x == 1)
        {
            int x = 0;
            if (vp2.size() >= 2) {
                x += vp2[0].second;
                x += vp2[1].second;
            }
            if (vp1.size()) {
                if (x) {
                    sm -= min(x, vp1[0].second);
                }
                else sm -= vp1[0].second;
            }
            else sm -= x;
        }
        else if (x == 2)
        {
            int x = 0; 
            if (vp1.size() >= 2) {
                x += vp1[0].second;
                x += vp1[1].second;
            } 
            if (vp2.size()) {
                if (x) {
                    sm -= min(x, vp2[0].second);
                }
                else sm -= vp2[0].second;
            }
            else sm -= x;
        }
        return sm;
    }
};
