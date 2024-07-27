public class Solution {
    public int RemoveDuplicates(int[] a) 
    {
        int index = 0, pre = a[0], c = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == pre)
            {
                if (c < 2) 
                {
                    a[index++] = a[i];
                    c++;
                }
            }
            else 
            {
                c = 1;
                a[index++] = a[i];
                pre = a[i];
            }
        }
        return index; 
    }
}