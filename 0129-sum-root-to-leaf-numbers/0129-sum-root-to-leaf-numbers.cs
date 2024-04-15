/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int sum = 0;
    void dfs(TreeNode root, int p)
    {
        if (root == null) return;
        int cur = p*10 + root.val;
        if (root.left == null && root.right == null) {
            sum += cur;
        }
        dfs(root.left, cur);
        dfs(root.right, cur);
    }
    public int SumNumbers(TreeNode root) 
    {
        dfs(root,0);
        return sum;
    }
}