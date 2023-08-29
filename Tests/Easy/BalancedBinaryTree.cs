using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Tests.Easy;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return Dfs(root) != -1;
    }

    public int Dfs(TreeNode? node)
    {
        if (node == null) return 0;

        var left = Dfs(node.left);

        // if left node has a leaf depth diff higher than one
        if (left == -1)
        {
            return -1;
        }

        var right = Dfs(node.right);

        // if right node has a leaf depth diff higher than one
        if (right == -1)
        {
            return -1;
        }

        // if depth of either left - depth of right is greater than one
        // it means that the depth difference is greater than one, so we return -1
        if (Math.Abs(left - right) > 1)
        {
            return -1;
        }

        // otherwise, return the max depth of left or right plus one for itself
        return 1 + Math.Max(left, right);
    }
}
