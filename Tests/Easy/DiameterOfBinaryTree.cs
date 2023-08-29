namespace Tests.Easy;

public class DiameterOfBinaryTreeTest
{
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

    private int _diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Dfs(root);
        return _diameter;
    }

    public int Dfs(TreeNode? node)
    {
        if (node is null)
        {
            return 0;
        }

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        _diameter = Math.Max(left + right, _diameter);

        return Math.Max(left, right) + 1;
    }
}