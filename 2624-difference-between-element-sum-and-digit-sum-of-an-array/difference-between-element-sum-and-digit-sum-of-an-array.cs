public class Solution {
    public int DifferenceOfSum(int[] nums) {
      int elsum=0;
      int dsum=0;
    //   int [] temp=new int[nums.Length];
    //   Array.Copy(nums,temp,nums.Length);
     
      for(int i=0;i<nums.Length;i++){
        elsum=elsum+nums[i];
        
        int temp=nums[i];
        while(temp>0){
        dsum=dsum+temp%10;
        temp=temp/10;  
        }
      
      }
      return Math.Abs(elsum-dsum);
    }
}