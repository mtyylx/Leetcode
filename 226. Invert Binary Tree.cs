/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root != null)
        {
            //InvertTree(root.left);
            //InvertTree(root.right);
            
            //TreeNode temp = root.left;
            //root.left = root.right;
            //root.right = temp;
            
            //Since the func has return its root, we can squize it into 3-liner.
            //Note: We can swap null value. It's safe. 
            //Note: When we swapped the TreeNode object, the val in it is also swapped. So no extra work required.
            TreeNode temp = InvertTree(root.left);
            root.left = InvertTree(root.right);
            root.right = temp;
        }
        return root;
    }
}