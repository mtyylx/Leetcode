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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
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
        return result;
    }
}