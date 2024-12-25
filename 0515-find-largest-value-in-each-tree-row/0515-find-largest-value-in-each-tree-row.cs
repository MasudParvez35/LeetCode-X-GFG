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
    public IList<int> LargestValues(TreeNode root) 
    {
        if (root == null)
            return new List<int>();
        
        var ans = new List<int>();
        var Q = new Queue<TreeNode>();

        Q.Enqueue(root);
        while(Q.Count > 0)
        {
            int maxValue = int.MinValue, len = Q.Count;
            for (int ind = 0; ind < len; ind++)
            {
                TreeNode node = Q.Dequeue();
                maxValue = Math.Max(maxValue, node.val);
                if (node.left != null) 
                    Q.Enqueue(node.left);
                if (node.right != null)
                    Q.Enqueue(node.right);
            }
            ans.Add(maxValue);
        }
        return ans;
    }
}