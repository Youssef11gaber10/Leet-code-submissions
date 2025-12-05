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
       Dictionary<int,int> indexofinorder = new Dictionary<int,int>();
        int iterator_of_preorder_findroot = 0;//this at first refer to root then when go right check which of left/right subtrees gets first
                                     //so it will be the root of left/right subtree
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {

        for (int i = 0; i < inorder.Length; i++)
        {
            indexofinorder[inorder[i]] = i;
        }
       return SplitTree(preorder,0,inorder.Length-1);

    }
    TreeNode SplitTree(int[] preorder, int left, int right)
    {
        if(left> right) return null;


        TreeNode root = new TreeNode(preorder[iterator_of_preorder_findroot]);//this is the root
        iterator_of_preorder_findroot++;//cause if it  has left sub tree need to check which one of its leftsub tree
                                        //gets first in preorder
             
        int mid = indexofinorder[root.val];//so this is the root in inorder so its left will be left subtree , right will be right sub tree
                                           //then recall the function to each one of them
        root.left = SplitTree(preorder, left, mid - 1);
        root.right = SplitTree(preorder, mid + 1, right);



        return root;


    }
}