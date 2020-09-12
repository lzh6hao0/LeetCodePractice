namespace LeetCodePractice.MathPractice{
    public class Q13RomanToInt{
        public int RomanToInt(string s){
            if(string.IsNullOrWhiteSpace(s))return 0;
            char[] c=s.ToCharArray();
            int len=c.Length;
            int perNum=GetRomanToInt(c[0]);
            int res=0;
            for(int i=0;i<len;i++){
                int temp= GetRomanToInt(c[i]);
                if(temp>perNum){
                    //如果当前数>前一个数，加上实际的数字大小，然后再从结果里将上一个数减掉
                    res=res+(temp-perNum)-perNum;
                }
                else{
                    res+=temp;
                }
                perNum=temp;
            }
            return res;
        }

        private int GetRomanToInt(char s ){
            switch(s){
                case 'I':return 1;
                case 'V':return 5;
                case 'X':return 10;
                case 'L':return 50;
                case 'C':return 100;
                case 'D':return 500;
                case 'M':return 1000;

            }
            return 0;
        }
    }
}