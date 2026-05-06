public class Solution {
    public int PivotIndex(int[] nums) {
        int rightsum=0;

        foreach(int num in nums){
            rightsum+=num;
        }

        int leftsum=0;
        for(int i=0;i<nums.Length;i++){
          rightsum=rightsum-nums[i];

          if(leftsum==rightsum){
            return i;
          }
           leftsum=leftsum+nums[i];
        }
       
       return -1; 
    }
}