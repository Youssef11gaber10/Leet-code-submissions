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
 
        int sum = 0;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if(root == null) return 0;
            
            RangeSumBST( root.left, low,  high);
            if(root.val > high)
                return sum;
            if(root.val >= low && root.val <= high) 
            {
                sum += root.val;
               
            }
            RangeSumBST(root.right, low, high);

            return sum;

        }//end of func


}//end of solution