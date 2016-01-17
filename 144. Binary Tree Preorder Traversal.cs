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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
    
        //Iterative Solution 1: using Stacks for cache
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count != 0)
        {
            root = stack.Pop();
            if(root != null)
            {
                result.Add(root.val);
                if(root.right != null) stack.Push(root.right);
                if(root.left != null) stack.Push(root.left);
            }
        }
        return result;
        
        //Iterative Solution 2: using Stacks for cache
        while(root != null || stack.Count() != 0)
        {
            if(root != null)
            {
                result.Add(root.val);
                stack.Push(root.right);
                root = root.left;
            }
            else
                root = stack.Pop();
        }
        return result;
        
        //Recursive Solution: use List to store the value.
        if(root != null)
        {
            result.Add(root.val);
            result.AddRange(PreorderTraversal(root.left));      //Add each element from the returned List<int> into result.
            result.AddRange(PreorderTraversal(root.right));
        }
        return result;
    }
}