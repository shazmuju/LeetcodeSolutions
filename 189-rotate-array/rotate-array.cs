public class Solution {
    public void Rotate(int[] nums, int k) {
        int n=nums.Length;
        k=k%n;

        Rev(nums,0,n-1);
        Rev(nums,0,k-1);
        Rev(nums,k,n-1);
    }

    private void Rev(int [] nums,int left,int right){
        while(left<right){
            int temp=nums[left];
            nums[left]=nums[right];
            nums[right]=temp;

            left++;
            right--;
        }
    }
}