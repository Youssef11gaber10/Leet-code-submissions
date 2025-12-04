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
   public bool IsValidBST(TreeNode root)
   {
       
       dfs(root);
       for(int i =1; i < list.Count; i++)
       {
           if (! (list[i-1] < list[i]))
               return false;

       }
       return true;

   }

   void dfs(TreeNode root)
   {
       if (root == null) return;

       dfs(root.left); 
       list.Add(root.val);
       dfs(root.right);

   }
}