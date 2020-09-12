using System;

namespace LeetCodePractice.MathPractice
{
    /// <summary>
    /// 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
    /// </summary>
    public class Q9IsPalindrome {
        
        /// <summary>
        /// 更优解
        /// 不用将原数全部反转，只需反转一半即可进行判断
        /// 当x<=已反转的数时，说明已经反转一半的数字了
        /// 若x数字个数为奇数，则反转后的数字个数会比x剩余数字个数多1，比较时需要将反转后的数/10去除中位数后再来比较
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindromeBest(int x)
        {
            if (x < 0 || (x % 10 == 0 && x > 0)) return false;
            int num = 0;
            while (x > num)
            {
                num = num * 10 + x % 10;
                x = x / 10;
            }
            return x == num || x == num / 10;
        }

        public bool IsPalindrome(int x) {
            if(x<0)return false;//有符号“-”，直接返回false
            //因为是整数，而int最大值是2147483647。如果想构成最大回文数，那么转换后，最高5位不能超过21474
            if (x>2147447412)return false;
            if(x%10==0 && x>0)return false;//如果大于0的数最后一位是0，那么反转之后肯定会比之前少一位，直接false
            int newX=0,
                useX=x;//将x的值赋值给一个新的变量，用于计算

            while (useX != 0){
                newX =newX*10+ useX % 10;
                useX = useX / 10;
            }
            
            if(newX==x)
                return true;
            return false;
        }

    }
}