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
    List<int> list = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        if(root == null) return new List<int>();

        InorderTraversal(root.left);
        list.Add(root.val);
        InorderTraversal(root.right);
        return list;
        
    }
}