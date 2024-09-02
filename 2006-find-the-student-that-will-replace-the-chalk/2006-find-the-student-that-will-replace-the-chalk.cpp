class Solution {
public:
    int chalkReplacer(vector<int>& a, int k) 
    {
        long long sum = 0;
        for (int i = 0; i < a.size(); i++) {
            sum += a[i];
        }
        k %= sum;
        cout << k << endl;
        sum = 0;
        for (int i = 0; i < a.size(); i++) {
            k -= a[i];
            if (k <= 0) {
                return i;
            }
        }
        return 0;
    }
};