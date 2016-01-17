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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        
        //Iterative Solution: using stacks
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(root != null || stack.Count != 0)
        {
            if(root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                root = stack.Pop();
                result.Add(root.val);
                root = root.right;
            }
        }
        return result;
        
        //Recursive Solution
        if(root != null)
        {
            result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            result.AddRange(InorderTraversal(root.right));
        }
        return result;
    }
}