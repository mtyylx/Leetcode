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
    public List<List<int>> LevelOrderBottom(TreeNode root) {
        //List of List to store the final result.
        List<List<int>> result = new List<List<int>>();
        //Queue to save each level in order and wait to be dequeued into List<int>.
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        //Solution 1: Use stack to store the List<List<int>>, then pop to Result.
        //Stack to temporarily save each tree level as a object into stack, 
        //waiting for reverse order output to List of List
        Stack<List<int>> stack = new Stack<List<int>>();

        //Return null when root is null
        if(root != null)
            queue.Enqueue(root);
            
        while(queue.Count != 0)
        {
            List<int> level = new List<int>();
            int count = queue.Count;
            for(int i = 0; i < count; i++)
            {
                root = queue.Dequeue();
                level.Add(root.val);
                if(root.left != null) queue.Enqueue(root.left);
                if(root.right != null) queue.Enqueue(root.right);
            }
            stack.Push(level);
        }
        //Pop up all level in bottom up order.
        while(stack.Count != 0)
        {
            result.Add(stack.Pop());
        }
        return result;
        
        
        //Solution 2: Same as Top-down Level Traversal, just reverse the result at the end.
        if(root != null)
            queue.Enqueue(root);
            
        while(queue.Count != 0)
        {
            //Initiate a List<int> container for each level.
            List<int> level = new List<int>();
            //Store the static size as loop condition (this is a must because queue.Count is shrinking in each loop.)
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                //Dequeue every node in the queue until empty
                root = queue.Dequeue();
                //Save each node value along the way.
                level.Add(root.val);
                //Enqueue its child at the end of the tail simultaneously.
                if(root.left != null) queue.Enqueue(root.left);
                if(root.right != null) queue.Enqueue(root.right);
            }
            //Save each level before cleanup for next level.
            result.Add(level);
        }
        result.Reverse();
        return result;
        
    }
}