
namespace LeetCodePractice.MathPractice{
    public class Q50MyPow{
        public double MyPow(double x,int n){
            long N=n;
            return N>=0?Calc(x,n):Calc(x,-n);

        }

        public double Calc(double x,int n){
            if(n==0)return 1.0;
            double res=1.0;
            double calc=x;
            while(n>0){
                if(n%2==1){
                    res*=calc;
                }
                calc*=calc;
                n/=2;
            }
            return res;
        }

    #region 使用递归
        public double MyPow1(double x, int n) {
            return Calc(x,n);
        }
    //当n=-2147483648时，如果取反，会造成溢出
        public double Calc(double x,long N){
            if(N==0|| (x-1 < 0.000001&&x-1 >- 0.000001))return 1;        
            else if(N>0 && N%2==0)return Calc(x*x,N/2);
            else if(N>0)return Calc(x,N-1)*x;
            else return 1.0/Calc(x,-N);
        }
    }
    #endregion
}