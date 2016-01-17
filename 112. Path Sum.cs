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
    public bool HasPathSum(TreeNode root, int sum) {
        //If root has no child, and sum - root.val == 0, then return true
        //If root has child, then sum = sum - root.val
        //If root does not exist, return false
        if(root==null)
            return false;
        sum = sum - root.val;
        if(root.left==null && root.right==null && sum == 0)
            return true;
        return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);   //Any path that has sum == 0 will eventually return true;
    }
}