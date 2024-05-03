public class Solution {
    public int CompareVersion(string s, string t) 
    {
        int i = 0; 
        int j = 0;
        int n1 = s.Length, n2 = t.Length;
        while(i<n1 || j<n2)
        {
            int sm1 = 0, sm2 = 0;
            while(i<n1 && s[i]!='.'){
                sm1 = sm1*10+(s[i]-'0');
                i++;
            }
            
            while(j<n2 && t[j]!='.'){
                sm2 = sm2*10+(t[j]-'0');;
                j++;
            }
            
            if(sm1>sm2) return 1;
            else if(sm1 < sm2) return -1;
            
            sm1 = 0;
            sm2 = 0;
            i++;
            j++;
        }
        return 0;
    }
}