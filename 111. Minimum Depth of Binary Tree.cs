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
    public int MinDepth(TreeNode root) {
        if(root==null)
            return 0;
            
        //Take care of tree without leftchild, no matter it has rightchild or not.  
        if(root.left == null)
            return 1 + MinDepth(root.right);
            
        //Take care of tree without rightchild (but has leftchild)
        if(root.right == null)
            return 1 + MinDepth(root.left);
            
        //Take care of tree that has both child
        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}