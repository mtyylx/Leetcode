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
    //ƽ��������ĵݹ鶨�壺������ƽ�� && ������ƽ�� && ���������߶Ȳ�С��2
    //�ؼ������ڣ�һ���ڵ�ĸ߶��������������߶ȸ�����Ǹ������ģ���һ���ڵ����������ĸ߶Ȳ�����������ľ���ֵ
    //���ڷ���ֵ�ǲ����͵ĵݹ麯����Ҫ������<�߼���>������һ·&&������ֻҪ��һ�εݹ���false������false
    
    //Solution 2: Use DFS to perform bottom up traversal
    //�����������Ƿ����-1��Ϊ�Ƿ�Ϊƽ�����Ĳ����жϡ�
    //����ڵ㲻���ڣ���ô�����Ϊ0
    //����ڵ��ӽڵ��Ѿ�����ƽ��������ô���Ϊ-1
    //����ڵ�����������Ȳ����1����ô���Ϊ-1
    //����ڵ�һ����������ô���Ϊ�������ֵ+1
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
    
    //����û�����������������ȵĵݹ������������Ȳ�ĵݹ�д��һ���Ľ����ȫ����
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