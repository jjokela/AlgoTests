namespace Tests.Easy;

internal class SubtreeOfAnotherTree
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

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (subRoot == null)
        {
            return true;
        }

        if (root == null)
        {
            return false;
        }

        if (IsSameTree(root, subRoot))
        {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((p, q));

        while (queue.Any())
        {
            var (node1, node2) = queue.Dequeue();

            if (node1 == null && node2 == null)
            {
                continue;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            queue.Enqueue((node1.left, node2.left));
            queue.Enqueue((node1.right, node2.right));
        }

        return true;
    }
}