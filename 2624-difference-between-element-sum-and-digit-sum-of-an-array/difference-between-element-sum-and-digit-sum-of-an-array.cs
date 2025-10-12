public class Solution {
    public int DifferenceOfSum(int[] nums) {
      int elementsum=0;
      int digitsum=0;
      int [] temp=new int[nums.Length];
      for(int i=0;i<nums.Length;i++){
        temp[i]=nums[i];
      }
      for(int i=0;i<nums.Length;i++){
        elementsum=elementsum+nums[i];

        if(temp[i]>9){
        while(temp[i]>0){
        digitsum=digitsum+temp[i]%10;
        temp[i]=temp[i]/10;  
        }
      
        }
         digitsum=digitsum+temp[i];
      }
      return Math.Abs(elementsum-digitsum);
    }
}