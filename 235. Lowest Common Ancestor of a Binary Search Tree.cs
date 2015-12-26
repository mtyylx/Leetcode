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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        while (true)
        {
            //p and q on different side of the tree: LCA is root
            if((p.val < root.val && q.val > root.val) || (p.val > root.val && q.val < root.val))
                return root;
            //p is the root: LCA is p
            if(p == root)
                return p;
            //q is the root: LCA is q
            if(q == root)
                return q;
            //p and q on the same side of the tree: digger deeper
            if(p.val < root.val)
                root = root.left;
            else
                root = root.right;
        }
    }
}