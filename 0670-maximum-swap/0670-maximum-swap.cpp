class Solution {
public:
    int maximumSwap(int num) 
    {
        string a = to_string(num);
        int n = a.size();
        int pos[10] = {0};  

        for (int i = 0; i < n; i++) {
            pos[a[i] - '0'] = i;
        }

        string sorted_a = a;
        sort(sorted_a.rbegin(), sorted_a.rend());
        
        for (int i = 0; i < n; i++) {
            if (a[i] != sorted_a[i]) {
                swap(a[i], a[pos[sorted_a[i] - '0']]);
                break;  
            }
        }
        
        // Convert the modified string back to an integer and return
        return stoi(a);
    }
};
