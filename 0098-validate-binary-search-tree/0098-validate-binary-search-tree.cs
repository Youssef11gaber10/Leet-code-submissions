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
 long previousval = long.MinValue;
  bool flag = true;

 public bool IsValidBST(TreeNode root)
 {
     
     dfs(root);
    
     return flag;

 }

 void dfs(TreeNode root)
 {
     if (root == null || flag ==false ) return;

     IsValidBST(root.left); 
     if(root.val > previousval)
     {
         previousval = root.val;
     }
     else
     {
         flag = false;
         return;
     }
     IsValidBST(root.right);

 }
}