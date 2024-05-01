public class Solution {
    public void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
    public string ReversePrefix(string ss, char c) 
    {
        int l = 0, r = ss.IndexOf(c);
        char[] s = ss.ToCharArray();
        while (l < r)
        {
            Swap(ref s[l++], ref s[r--]);
        }
        return new string(s);
    }
}