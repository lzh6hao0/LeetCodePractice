using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.MathPractice
{
    public class Q7IntergerReverse
    {
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                //如果一个数*10溢出后，再除以10，那么肯定就不等于它原来的值
                //如果*10没有溢出，那么加上 最后一位数也不会发生溢出
                //int的最大值2147483647，所以反转后，最后一位肯定为1或者2，不会超过7
                if (res * 10 / 10 != res)
                {
                    res = 0;
                    break;
                }
                res = res * 10 + x % 10;
                x /= 10;
            }
            return res;
        }
    }
}
