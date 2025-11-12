public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        int[] arr=new int[nums.Length];

        for(int i=0;i<nums.Length;i=i+2){
            arr[i]=nums[i+1];
            arr[i+1]=nums[i];
        }
        return arr;
    }
}