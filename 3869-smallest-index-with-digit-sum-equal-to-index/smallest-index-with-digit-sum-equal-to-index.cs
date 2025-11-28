public class Solution {
    public int SmallestIndex(int[] nums) {
        for(int i=0;i<nums.Length;i++){
        int digitsum=0;
        int temp=nums[i];
        while(temp>0){
        digitsum+=temp%10;
        temp=temp/10;
        }
        if(digitsum==i){
            return i;
        }
       
      }
      return -1;
        
    }
}