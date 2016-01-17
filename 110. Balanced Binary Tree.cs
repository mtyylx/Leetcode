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
    //平衡二叉树的递归定义：左子树平衡 && 右子树平衡 && 左右子树高度差小于2
    //关键点在于，一个节点的高度是其两个子树高度更大的那个决定的，而一个节点左右子树的高度差是两者相减的绝对值
    //对于返回值是布尔型的递归函数，要考虑用<逻辑与>来做到一路&&下来，只要有一次递归是false最后就是false
    
    //Solution 2: Use DFS to perform bottom up traversal
    //本质上是用是否等于-1作为是否为平衡树的布尔判断。
    //如果节点不存在，那么其深度为0
    //如果节点子节点已经不是平衡树，那么深度为-1
    //如果节点两个子树深度差大于1，那么深度为-1
    //如果节点一切正常，那么深度为子树最大值+1
    public int IsBalancedint(TreeNode root)
    {
        int depth = 0;
        while(root != null)
        {
            int left = IsBalancedint(root.left);
            int right = IsBalancedint(root.right);
            if(left != -1 && right != -1 && Math.Abs(left-right) < 2) return 1 + Math.Max(left, right);
            else return -1;
        }
        return depth;
    }
    
    public bool IsBalanced(TreeNode root)
    {
        return IsBalancedint(root)>=0;
    }
    
    //Solution 1: Use helper function to top down traversal
    //public bool IsBalanced2(TreeNode root) 
    //{
    //    if(root != null) return IsBalanced2(root.left) && IsBalanced2(root.right) && Math.Abs(Depth(root.left)-Depth(root.right)) < 2; 
    //    else return true;
    //}
    
    //public int Depth(TreeNode root)
    //{
    //    if(root != null) 1 + Math.Max(Depth(root.left), Depth(root.right));
    //    else return 0; 
    //}
    
    //脑子没想清楚，把求子树深度的递归和两个子树深度差的递归写成一个的结果：全乱了
    //public int TreeDepth(TreeNode root)
    //{
    //    int depth = 0;
    //    if(root != null)
    //    {
    //        if(root.left != null || root.right != null)
    //            int depthLeft = TreeDepth(root.left);
    //            int depthRight = TreeDepth(root.right);
    //            if(Math.Abs(depthLeft - depthRight) < 2)
    //                depth = Math.Max(depthLeft, depthRight) + 1;
    //            else
    //                depth = -1;
    //    }
    //    return depth;
    //}
}