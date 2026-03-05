public class Solution {
    public int MaxSubArray(int[] nums) {
        int currsum=nums[0];
        int maxsum=nums[0];

        for(int i=1;i<nums.Length;i++){
            currsum=Math.Max(nums[i],nums[i]+currsum);
            maxsum=Math.Max(maxsum,currsum);
        }
        return maxsum;
    }
}