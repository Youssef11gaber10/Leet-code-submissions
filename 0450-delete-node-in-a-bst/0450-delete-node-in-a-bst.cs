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


        public TreeNode DeleteNode(TreeNode root, int key)
        {

            if (root == null) return null;
            if (key > root.val)
            {
                root.right= DeleteNode(root.right, key);
            }
            else if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else//i found the key
            {
                if (root.right == null && root.left == null)//has no child
                {

                    return null;//this null will hit in on of those( root.right= DeleteNode(root.right, key);)

                }//end of case 1

                if (root.right == null || root.left == null)//one of them was null
                {
                    TreeNode child = (root.left != null) ? root.left : root.right;
                    return child; //this child will hit in on of those( root.right= DeleteNode(root.right, key);)
                }//end of case 2

                //case 3 has 2 child find the successor
                if (root.right != null && root.left != null)
                {
                    TreeNode successor = Successor(root);
                    //i will swap val of successor with root 
                    root.val = successor.val;
                    //so i successor now suppose to be in place of root so i want to delete the 
                    //root so call the delete node for successor as node have 1 child
                    //and make successor parent its genral parent cause don't cause any problem
                    //when delete
                   

                    root.right = DeleteNode(root.right, successor.val);//search for successor and value and delete it;

                }//end of case three



            }//end of found the key 





            //if not found the key return root;
            return root;




        }//end of function

        TreeNode Successor(TreeNode root)
        {
            root = root.right;
            while (root.left != null)
            {
                root = root.left;
            }

            return root;

        }



}
