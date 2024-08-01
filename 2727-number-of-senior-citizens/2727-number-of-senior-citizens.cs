public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (var i in details)
        {
            if (i[11] > '6' || (i[11] >= '6' && i[12] > '0'))
                count++;
        }
        return count;
    }
}