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
    void dfs(TreeNode root, List<int> ans)
    {
        if (root == null)
            return;
        dfs(root.left, ans);
        ans.Add(root.val);
        dfs(root.right, ans);
    }
    public IList<int> InorderTraversal(TreeNode root) 
    {
        List<int> ans = new List<int>();
        dfs(root, ans);
        return ans;
    }
}