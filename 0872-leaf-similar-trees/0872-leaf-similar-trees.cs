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
    public void Dfs(TreeNode root, List<int> v)
    {
        if (root == null) return;
        if (root.left == null && root.right == null) v.Add(root.val);
        Dfs(root.left, v);
        Dfs(root.right, v);
    }
    public bool LeafSimilar(TreeNode a, TreeNode b) 
    {
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        
        Dfs(a, x);
        Dfs(b, y);
        
        return x.SequenceEqual(y);
    }
}