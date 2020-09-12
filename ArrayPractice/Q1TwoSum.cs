using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.ArrayPractice
{
    public class Q1TwoSum
    {
        /// <summary>
        /// 使用双重循环
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumByDoubleCycle(int[] nums, int target)
        {
            int len = nums.Length;
            if (len < 2) return null;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }

            }
            return null;
        }

        /// <summary>
        /// 使用Dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            if (len < 2) return null;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                int difference = target - nums[i];
                if (dic.ContainsKey(difference) && dic[difference] != i)
                    return new int[] { dic[difference], i };
                else
                    dic.Add(nums[i], i);
            }
            return null;
        }

    }
}
