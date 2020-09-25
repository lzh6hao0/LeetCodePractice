using System.Collections.Generic;
namespace LeetCodePractice.TreePractice{
    public class Q226InvertTree{
        //使用层序遍历
        public TreeNode InvertTree(TreeNode root){
            if(root==null)return null;
            Queue<TreeNode> queue= new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count!=0){
                int count=queue.Count;
                for(int i=0;i<count;i++){
                    TreeNode cur = queue.Dequeue();
                    TreeNode temp=cur.left;
                    cur.left=cur.right;
                    cur.right=temp;
                    if(cur.left!=null)queue.Enqueue(cur.left);
                    if(cur.right!=null)queue.Enqueue(cur.right);
                }
            }
            return root;
        }
    }
}