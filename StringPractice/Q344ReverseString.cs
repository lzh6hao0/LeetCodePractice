namespace LeetCodePractice.StringPractice{
    public class Q344ReverseString{
        public void ReverseString(char[] s){
            int len=s.Length;
            for(int i=0,j=len-1;i<j;i++,j--){
                s[i]^=s[j];
                s[j]^=s[i];
                s[i]^=s[j];
            }
        }
    }
}