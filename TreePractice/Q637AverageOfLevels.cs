using System.Collections.Generic;

namespace LeetCodePractice.TreePractice{


   
    public class Q637AverageOfLevels{

        /// <summary>
        /// 使用双队列
        /// 一个队列Q1又来存储当前层节点
        /// 另一队列Q2存储当前层节点的子节点
        /// 当Q1中数量=0时，将Q2中的节点全部入到Q1当中
        /// 如果Q1和Q2的数量都为0时，表明树已遍历完
        /// 
        /// 效率较低，还需优化
        /// </summary>
        public IList<double> AverageOfLevels(TreeNode root){
            Queue<TreeNode> parentQueue = new Queue<TreeNode>();
            Queue<TreeNode> childQueue = new Queue<TreeNode>();
            parentQueue.Enqueue(root);//先将root节点入到父队列
            TreeNode currentNode = null;
            int levelsCount = 0;
            int levelsSum = 0;
            IList<double> res = new List<double>();
            while (parentQueue.Count != 0)
            {
                currentNode = parentQueue.Dequeue();
                levelsSum += currentNode.val;
                levelsCount++;
                if (currentNode.left != null) childQueue.Enqueue(currentNode.left);
                if (currentNode.right != null) childQueue.Enqueue(currentNode.right);
                //当父队列没有元素时，求平均值，然后将count和sum置为0，并将childQueue中的元素全部入到父队列中
                if (parentQueue.Count == 0)
                {
                    double average = (double)levelsSum / levelsCount;
                    levelsCount = 0;
                    levelsSum = 0;
                    res.Add(average);
                    while (childQueue.Count != 0)
                    {
                        parentQueue.Enqueue(childQueue.Dequeue());
                    }
                }
            }
            return res;
        }
    }

    
  //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

}