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
    int ans = 0;
    void dfs(TreeNode root)
    {
        if (root == null) return;
        if (root.left != null)
        {
            if (root.left.left == null && root.left.right == null) {
                ans += root.left.val;
            }
        }
        dfs(root.left);
        dfs(root.right);
    }
    public int SumOfLeftLeaves(TreeNode root) 
    {
        dfs(root);
        return ans;
    }
}