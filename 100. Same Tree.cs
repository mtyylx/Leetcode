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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        //return true if both p and q are empty.
        if (p==null && q==null)
            return true;
        //at this point, it's impossible for both p and q to be empty.
        if (p==null || q==null)
            return false;
        //at this point, both p and q MUST have been non-empty.
        if (p.val != q.val)
            return false;
        else 
            return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
    }
}