namespace LeetCodePractice.ArrayPractice{
    public class Q27RemoveElement
    {
        public int RemoveElement(int[] nums,int val){
            int len=nums.Length;
            int index=0;
            for(int i=0;i<len;i++){
                if(nums[i]!=val){
                    nums[index]=nums[i];
                }
            }
            return index;
        }
    }
}