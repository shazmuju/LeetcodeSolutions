public class Solution {
    public int DifferenceOfSum(int[] nums) {
      int elsum=0;
      int dsum=0;
      int [] temp=new int[nums.Length];
      Array.Copy(nums,temp,nums.Length);
     
      for(int i=0;i<nums.Length;i++){
        elsum=elsum+nums[i];
    
        while(temp[i]>0){
        dsum=dsum+temp[i]%10;
        temp[i]=temp[i]/10;  
        }
      
      }
      return Math.Abs(elsum-dsum);
    }
}