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
    
         int val = -1;
 int counter = 0;
 public int KthSmallest(TreeNode root, int k)
 {

     dfs(root, k);
     return val;


 }
 void dfs(TreeNode root, int k)
 {
     if(root == null || val != -1) return;
     dfs(root.left,k);

     counter++;//once you get here you suppose to print so increment the counter
     if (counter  == k)//if this counter is the k you search return it
     {
         val = root.val;
         return;
     }
     

     dfs(root.right,k);
 }

}