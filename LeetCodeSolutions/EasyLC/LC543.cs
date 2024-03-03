using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Diameter of a binary tree.
    /// </summary>
    public class LC543
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int diameter = 0;
            FindHeight(root, ref diameter);
            return diameter;
        }

        private int FindHeight(TreeNode root, ref int diameter)
        {
            if (root == null) return 0;

            int leftHeight = FindHeight(root.left, ref diameter);
            int rightHeight = FindHeight(root.right, ref diameter);
            diameter = Math.Max(diameter, leftHeight + rightHeight);
            return 1 + Math.Max(leftHeight, rightHeight); // return to the parent by adding 1 to the current height.
        }
    }

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
}