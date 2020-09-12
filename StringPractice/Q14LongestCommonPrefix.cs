using System;
namespace LeetCodePractice.StringPractice{
    public class Q14LongestCommonPrefix{
        public string LongestCommonPrefix1(string[] strs){
            if(strs==null)return "";
            int strsLen=strs.Length;
            if(strsLen==0)return "";
            char[] c= strs[0].ToCharArray();
            int maxIndex=c.Length;
            for(int i=0;i<strsLen;i++){
                if(maxIndex==0)break;
                char[] temp = strs[i].ToCharArray();
                maxIndex=temp.Length<maxIndex?temp.Length:maxIndex;
                for(int j=0;j<maxIndex;j++){
                    if(c[j]!=temp[j]){
                        maxIndex=j;
                        break;
                    }
                }
            }
            string res="";
            for(int i=0;i<maxIndex;i++)
                res+=c[i];
            return res;
        }

        ///该算法用时比1多
        public string LongestCommonPrefix2(string[] strs){
            if(strs==null || strs.Length==0)return "";
            string res= strs[0];
            foreach(string s in strs){
                while(s.IndexOf(res)!=0){
                    res=res.Substring(0,res.Length-1);
                }
            }
            return res;
        }

        ///纵向比较，依次比较数组中每个字符串的每个元素。如果有某个字符串长度小于当前比较的下标I+1，或者不相等，那么直接返回之前的字符串
        public string LongestCommonPrefix3(string[] strs){
            if(strs==null || strs.Length==0)return "";

            string res=strs[0];
            int len=res.Length;
            bool flag= false;
            for(int i=0;i<len;i++){
                foreach(string str in strs){
                    
                    if(str.Length<i+1 || res[i]!=str[i]){
                        flag=true;
                        break;
                    }
                }
                if(flag){
                    res=res.Substring(0,i);
                    break;
                }
            }
            return res;
        }


        //字符串按照ascii排序后，排序我是用的c#中的Array.Sort()方法，取首尾两个字符串进行前缀比较，用两个数的最小长度作为比较范围，如果遇到不相同的字符，则将s1截取到字符位置不同的地方，并退出循环。
        //该算法时间复杂度主要是在排序，Array.Sort()官方文档中说的是时间复杂度为O(nlogn)

         public string LongestCommonPrefix4(string[] strs){
             if(strs==null || strs.Length==0)return "";
             Array.Sort(strs,string.CompareOrdinal);
            string s1=strs[0];
            string s2=strs[strs.Length-1];
            int maxIndex= s1.Length<=s2.Length?s1.Length:s2.Length;
            for(int i=0;i<s1.Length;i++){
                if(s1[i]!=s2[i]){
                    s1=s1.Substring(0,i);
                    break;
                }                   
            }
            return s1;
         }
    }
}