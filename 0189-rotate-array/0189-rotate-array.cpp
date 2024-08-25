class Solution {
public:
    void rotate(vector<int>& nums, int k) 
    {
        k %= nums.size();
        reverse(nums.begin(), nums.end());
        int i = 0, j = k-1;
        while(i < j) {
            swap(nums[i++], nums[j--]);
        }
        i = k, j = nums.size()-1;
        while(i < j) {
            swap(nums[i++], nums[j--]);
        }
    }
};