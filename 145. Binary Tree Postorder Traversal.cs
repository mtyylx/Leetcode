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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        //Iterative: the real Postorder traversal using two flags.
        if(root != null)
            stack.Push(root);
        TreeNode prev = null;
        while (stack.Count != 0)
        {
            root = stack.Peek();

            bool noChild = (root.left == null && root.right == null);
            bool doneChild = false;

            if (prev != null && (prev == root.left || prev == root.right))
                doneChild = true;
           
            //直到没有child了或者child已经访问完了才把栈顶元素出栈
            if (noChild || doneChild)
            {
                root = stack.Pop();
                result.Add(root.val);
                prev = root;
            }
            else
            {
                if (root.right != null)
                    stack.Push(root.right);
                if (root.left != null)
                    stack.Push(root.left);
            }
        }
        return result;
        
        
        //Iterative: Just reverse the Pre-Order Traversal.
        while(root != null || stack.Count != 0)
        {
            if(root != null)
            {
                result.Add(root.val);
                if(root.left != null) stack.Push(root.left);
                root = root.right;
            }
            else
            {
                root = stack.Pop();
            }
        }
        result.Reverse();
        return result;
        
                
        //Recursive: so easy.
        if(root != null)
        {
            result.AddRange(PostorderTraversal(root.left));
            result.AddRange(PostorderTraversal(root.right));
            result.Add(root.val);
        }
        return result;
    }
}