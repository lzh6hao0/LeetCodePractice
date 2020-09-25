using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.ArrayPractice
{
    public class Q35SearchInsert
    {
        #region
        public int SearchInsert(int[] nums, int target)
        {
            int high = nums.Length;
            int low = 0;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    high = mid;
                }
                else low = mid + 1;
            }
            return low;
        }


        #endregion

        #region 二分查找第一版
        public int SearchInsert1(int[] nums,int target)
        {
            int high = nums.Length;
            if (high == 0) return 0;
            return BinarySearch(nums, 0, high - 1, target);
        }

        public int BinarySearch(int[] nums, int low, int high, int key)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == key) return mid;
            else if (high == low && key > nums[high]) return high + 1;
            else if (high == low && key < nums[low]) return low;
            else if (nums[mid] < key) return BinarySearch(nums, mid + 1, high, key);
            else if (nums[mid] > key) return BinarySearch(nums, low, mid, key);
            else return 0;
        }
        #endregion
    }
}
