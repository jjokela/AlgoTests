﻿namespace Tests.Easy;

internal class MaxDepthOfBinaryTree
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

    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}