class Solution {
public:
    int findLucky(vector<int>& arr) 
    {
        map <int,int> fre;
        for (auto item : arr)
            fre[item]++;
        
        int ans = -1;
        for (auto item : fre)
        {
            int key = item.first;
            int value = item.second;

            if (key == value)
                ans = key;
        }
        return ans;
    }
};