class Solution {
public:
    string Bit(int n) {
        string s = "";
        while(n > 0) {
            int r = n%2;
            s += (r+'0');
            n /= 2;
        }
        return s;
    }
    int minBitFlips(int s, int g) 
    {
        int ans = 0;
        string a = Bit(s), b = Bit(g);
        int mi = min((int)a.size(), (int)b.size());
        int mx = max((int)a.size(), (int)b.size());
        for (int i = 0; i < mi; i++)
        {
            if (a[i] != b[i]) ans++;
        }
        for (int i = mi; i < mx; i++)
        {
            if (i < a.size()) {
                if (a[i] == '1') ans++;
            }
            if (i < b.size()) {
                if (b[i] == '1') ans++;
            }
        }
        return ans;
    }
};