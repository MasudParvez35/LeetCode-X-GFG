public class Solution {
    public long CountSubstrings(string s, char c) 
    {
        long cnt = 0;
        foreach (char i in s) {
            if (i == c) cnt++;
        }
        return (cnt*(cnt+1))/2;
    }
}