using System.Collections.Generic;
namespace LeetCodePractice.TreePractice{
    ///中序遍历：先访问左子树，然后根节点，最后右子树
    ///每遍历一个节点，就将其压入栈中
    ///如果没有左子树，那么栈就抛出一个元素，先输出节点值，然后指向抛出节点的右子树
    public class Q97InorderTraversal{
        public IList<int>InorderTraversal(TreeNode root){
            Stack<TreeNode>stack= new Stack<TreeNode>();
            TreeNode node=root;
            IList<int> list = new List<int>();
            while(node!=null || stack.Count!=0){
                while(node!=null){  
                    stack.Push(node);
                    node=node.left;
                }
                if(stack.Count!=0){
                    node=stack.Pop();
                    list.Add(node.val);
                    node=node.right;
                }
            }
            return list;
        }
    }
}