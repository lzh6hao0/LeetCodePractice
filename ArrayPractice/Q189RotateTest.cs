using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.ArrayTest
{
    class Q189Rotate
    {
        //给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。

        //示例 1:

        //输入: [1,2,3,4,5,6,7]
        //        和 k = 3
        //输出: [5,6,7,1,2,3,4]
        //        解释:
        //向右旋转 1 步: [7,1,2,3,4,5,6]
        //        向右旋转 2 步: [6,7,1,2,3,4,5]
        //        向右旋转 3 步: [5,6,7,1,2,3,4]
        //        示例 2:

        //输入: [-1,-100,3,99]
        //        和 k = 2
        //输出: [3,99,-1,-100]
        //        解释: 
        //向右旋转 1 步: [99,-1,-100,3]
        //        向右旋转 2 步: [3,99,-1,-100]
        //        说明:

        //尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
        //要求使用空间复杂度为 O(1) 的原地算法。

        /// <summary>
        /// 旋转数组
        /// 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>

        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            if (k == 0) return;
            //新數組用於存放移動后的元素
            int[] newArr = new int[len];
            for (int i = 0; i < len; i++)
            {
                newArr[(i + k) % len] = nums[i];
            }

            for (int i = 0; i < len; i++)
            {
                nums[i] = newArr[i];
            }
        }


        public void Rotate1(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            if (k == 0) return;
            List<int> list = nums.ToList();
            //截取最後K位元素
            List<int> splitList1 = list.Skip(len - k).Take(k).ToList();
            //截取前面len-k位
            List<int> splitList2 = list.Take(len - k).ToList();
            //合併兩個list
            splitList1.AddRange(splitList2);
            //數組重新賦值
            for (int i = 0; i < len; i++)
            {
                nums[i] = splitList1[i];
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate2(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            if (k == 0) return;
            //新建數組存放最後K個元素
            int[] newArr = nums.Skip(len - k).Take(k).ToArray();
            //len-k之前的元素向右移動K
            for (int i = len - 1; i >= k; i--)
            {
                nums[i] = nums[i - k];
            }
            //將新數組插入移動后的數組
            for (int i = 0; i < k; i++)
            {
                nums[i] = newArr[i];
            }
        }
    }
}
