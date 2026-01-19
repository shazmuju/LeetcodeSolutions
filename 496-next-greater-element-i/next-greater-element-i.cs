public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int n1=nums1.Length;
        int n2=nums2.Length;
        int [] result=new int[n1];
        for(int i=0;i<n1;i++){
            result[i]=-1;
            for(int j=0;j<n2;j++){
                if(nums1[i]==nums2[j]){
                    for(int k=j+1;k<nums2.Length;k++){
                        if(nums2[k]>nums2[j]){
                            result[i]=nums2[k];
                            break;
                        }
                    }
                   break;
                }
            }
        }
        return result;
    }
}