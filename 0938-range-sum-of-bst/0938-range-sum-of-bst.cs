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
    public int RangeSumBST(TreeNode root, int l, int h) 
    {
        if (root == null) return 0;
        int cur = (root.val >= l && root.val <= h) ? root.val : 0;
        int left = RangeSumBST(root.left, l, h);
        int right = RangeSumBST(root.right, l, h);
        return cur + left + right;
    }
}