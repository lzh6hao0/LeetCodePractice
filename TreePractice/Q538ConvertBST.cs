using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.TreePractice
{
    public class Q538ConvertBST
    {
        public TreeNode ConvertBst(TreeNode root)
        {
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;
            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.right;
                }
                if (stack.Count != 0)
                {
                    current = stack.Pop();
                    current.val += sum;
                    sum = current.val;
                    current = current.left;
                }
            }
            return root;
        }
    }
}
