public class Solution {
    public int NumWaterBottles(int x, int y) {
        return x + (x-1) / (y-1);
    }
}