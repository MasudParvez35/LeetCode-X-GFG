class Solution {
public:
    int chalkReplacer(vector<int>& a, int k) 
    {
        int n = a.size();
        long long sm = 0;
        for (int i = 0; i < n; i++) sm += a[i];
        int x = k % sm;
        for (int i = 0; i < n; i++) {
            if (a[i] > x) {
                return i;
            }
            else {
                x -= a[i];
            }
        }
        return -1;
    }
};