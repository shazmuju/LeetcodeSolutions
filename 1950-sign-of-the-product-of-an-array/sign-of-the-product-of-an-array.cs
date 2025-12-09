public class Solution {
    public int ArraySign(int[] nums) {
        int negativecount=0;
        foreach(int num in nums){
            if(num==0){
                return 0;
            }
            else if(num<0){
                negativecount++;
            }
        }
        if(negativecount%2==0){
            return 1;
        }
        return -1;
    }
   
}
