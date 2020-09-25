namespace LeetCodePractice.StringPractice{
    public class Q28StrStr{
        public int StrStr(string haystack, string needle) {
            int hLen = haystack.Length;
            int nLen = needle.Length;
            if (hLen < nLen) return -1;
            for(int i = 0; i < hLen - nLen+1; i++)
            {
                string temp = haystack.Substring(i, nLen);
                if (temp == needle) return i;
            }
            return -1;
        }
    }
}