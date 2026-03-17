public class Solution {
    public bool CanJump(int[] nums) {
        int n=nums.Length;
        int LastReachable=n-1;

        for(int i=n-2;i>=0;i--){
            if(nums[i]>=LastReachable-i){
                LastReachable=i;
            }
        }

        return LastReachable==0;
    }
}