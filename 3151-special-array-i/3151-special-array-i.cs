public class Solution {
    public bool IsArraySpecial(int[] a) 
    {
        for (int i = 0; i < a.Length-1; i++)    
        {
            if ((a[i]+a[i+1]) % 2 == 0) return false;
        }
        return true;
    }
}