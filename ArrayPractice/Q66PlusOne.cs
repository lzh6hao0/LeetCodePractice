using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.ArrayTest {
    class Q66PlusOne {

        public int[] PlusOne(int[] digits) {
            int len = digits.Length;
            //判断最后一位是否为9，如果不是，则最后一位+1即可
            if (digits[len - 1] != 9) {
                digits[len - 1] += 1;
                return digits;
            }
            else {
                //否则往前遍历，等于9的都设为0，一直找到不等于9的那一位
                for(int i = len - 1; i >= 0; i--) {
                    if (digits[i] == 9) {
                        digits[i] = 0;
                    }
                    else {
                        digits[i] += 1;
                        break;
                    }
                }
            }
            //判断第一位是否为0,如果是，则重新生成一个数组，并将第0位设为1
            if (digits[0] == 0) {
                List<int> list = new List<int>();
                list.Add(1);
                list.AddRange(digits);
                digits = list.ToArray();                               
            }
            return digits;
        }
    }
}
