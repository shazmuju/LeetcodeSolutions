public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n=nums.Length;
        int [] arr=new int[n];
        for(int i=0;i<nums.Length;i++){
          arr[i]=nums[i]*nums[i];
        }
        Array.Sort(arr);
        return arr;
    }
}