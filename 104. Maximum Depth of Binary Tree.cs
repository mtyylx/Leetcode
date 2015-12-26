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
    public int MaxDepth(TreeNode root) {
        //if root exist, then the tree should at least has a depth of 1. Plus the max of its two subtree depth.
        if(root!=null)
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        //if root does not exist, then this tree depth is 0
        else
            return 0;
    }
}