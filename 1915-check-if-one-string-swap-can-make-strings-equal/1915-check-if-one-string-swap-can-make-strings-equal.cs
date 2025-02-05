public class Solution {
    public bool AreAlmostEqual(string s1, string s2) 
    {
        int cnt = 0, ind1 = 0, ind2 = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                cnt++;
                if (ind1 == 0)
                    ind1 = i;
                else
                    ind2 = i;
            }
        }
        if (cnt == 0)
            return true;
        else if (cnt == 2)
        {
            if (s1[ind1] == s2[ind2] && s1[ind2] == s2[ind1])
                return true;
            else 
                return false;
        }
        else
            return false;
    }
}