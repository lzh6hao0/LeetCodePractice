using System.Collections.Generic;

namespace LeetCodePractice.TreePractice{


   
    public class Q637AverageOfLevels{

        /// <summary>
        /// ʹ��˫����
        /// һ������Q1�����洢��ǰ��ڵ�
        /// ��һ����Q2�洢��ǰ��ڵ���ӽڵ�
        /// ��Q1������=0ʱ����Q2�еĽڵ�ȫ���뵽Q1����
        /// ���Q1��Q2��������Ϊ0ʱ���������ѱ�����
        /// 
        /// Ч�ʽϵͣ������Ż�
        /// </summary>
        public IList<double> AverageOfLevels(TreeNode root){
            Queue<TreeNode> parentQueue = new Queue<TreeNode>();
            Queue<TreeNode> childQueue = new Queue<TreeNode>();
            parentQueue.Enqueue(root);//�Ƚ�root�ڵ��뵽������
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
                //��������û��Ԫ��ʱ����ƽ��ֵ��Ȼ��count��sum��Ϊ0������childQueue�е�Ԫ��ȫ���뵽��������
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