using System.Collections.Generic;
namespace LeetCodePractice.StringPractice{
    public class Q20IsValid{
        #region 当前括号为左括号时，栈中存与之相对应的右括号

        public bool IsValid(string s){
            Stack<char>stack = new Stack<char>();
            int len=s.Length;
            foreach(char c in s){
                if(c=='(')stack.Push(')');
                else if(c=='[')stack.Push(']');
                else if(c=='{')stack.Push('}');
                else if(stack.Count==0 || c!=stack.Pop())return false;
            }
            return stack.Count==0;
        }
        #endregion



        #region 使用栈存储本来字符本身
        public bool IsValid1(string s){
           if(s==null)return false;
        Stack<char> stack = new Stack<char>();
        int len=s.Length;
        for(int i=0;i<len;i++){
            if(!oper(stack,s[i])){
                return false;
            }
        }
        return stack.Count==0;
    }

    public bool oper(Stack<char>stack,char c){
        bool flag=true;
        switch(c){
            case '{':
            case '(':
            case '[':stack.Push(c);
                break;
            case ')':if(stack.Count==0 || stack.Pop()!='('){
                flag=false;
            }
                    break;
            case ']':if(stack.Count==0 || stack.Pop()!='['){
                flag=false;
            }
                    break;
            case '}':if(stack.Count==0 || stack.Pop()!='{'){
                flag=false;
            }
                    break;
        }
        return flag;
    }
        #endregion
    }
}