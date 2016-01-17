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
    public bool IsSymmetric(TreeNode root) {
        //To be symmetric, the structure need to be the same
        //To be symmetric, the value of the mirror node need to be the same
        
        //The difficulty of this problem is that we cannot compare left/right node on different subtree without extra space.
        //To crack this, we can either use recursion to manually select the node to be compared:
            //Like -> IsSym(rootA.left, rootB.right) && IsSym(rootA.right, rootB.left);
        //Or we can use stack or queue to put each pair of node together (whereas previously they were on different subtree), then check their similarity.
        
        //-------------------------------------------------------------------------
        //Solution 2: Iterative way using Stack.
        //Change the order of each level of the tree:
        //Before: left.left, left.right, right.left, right, right
        //After: left.left, right.right, left.right, right.left
        if(root == null)
            return true;
            
        Stack<TreeNode> data = new Stack<TreeNode>();
        data.Push(root.right);
        data.Push(root.left);
        
        //精妙的地方就在于通过一个个判断将各种可能情况一一筛选出来加以处理
        while(data.Count != 0)
        {
            TreeNode left = data.Pop();
            TreeNode right = data.Pop();
            
            //If both of them reached end of tree, symmetrical
            //No more node need to be stored, just skip to next loop to scan the rest pair of node until stack is empty.
            if(left == null && right == null)
                continue;
            
            //If left is null but right is not null or vice versa, not symmetrical
            if(left == null || right == null)
                return false;
                
            //If both node exist but value is different, not symmetrical
            if(left.val != right.val)
                return false;
            
            //If both node exist and value is the same, continue push their child into stack in the modified order
            data.Push(left.left);
            data.Push(right.right);
            data.Push(left.right);
            data.Push(right.left);
        }
        //If the entire tree is traversed, it must be symmetrical.
        return true;
                
        //-------------------------------------------------------------------------
        //Solution 1: Recursive way by define a helper function to compare each pair.
        return IsSym(root, root);
    }
    
    
    private bool IsSym(TreeNode rootA, TreeNode rootB)
    {
        //If both node does not exist, then the structure is the same, thus return true
        if(rootA == null && rootB == null)
            return true;
        
        //If both node exist, then check if the value are the same
        if(rootA != null && rootB != null)
        {
            //If value are the same, then compare the A's left child and B's right child plus A's right child and B's left child.
            if(rootA.val == rootB.val)
                return IsSym(rootA.left, rootB.right) && IsSym(rootA.right, rootB.left);//Return true only if both child are symmetric.
            else
                return false;
        }
        
        //If only one of the two nodes to be compared exist, the structure are the not same, return false
        return false;
    }
}