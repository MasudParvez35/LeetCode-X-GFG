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
    public int dfs(TreeNode root, int mx, int mi)
    {
        if (root == null) return mx-mi;
        mx = Math.Max(mx, root.val);
        mi = Math.Min(mi, root.val);
        int left = dfs(root.left, mx, mi);
        int right = dfs(root.right, mx, mi);
        return Math.Max(left, right);
    }
    public int MaxAncestorDiff(TreeNode root) 
    {
        return dfs(root, 0, int.MaxValue);
    }
}