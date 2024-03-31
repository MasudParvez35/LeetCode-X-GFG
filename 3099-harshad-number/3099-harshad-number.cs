public class Solution {
    public int sum(int n) 
    {
        int sm = 0;
        while(n > 0) {
            sm += n%10;
            n /= 10;
        }
        return sm;
    }
    public int SumOfTheDigitsOfHarshadNumber(int n) 
    {
        return n % sum(n) == 0 ? sum(n) : -1;
    }
}