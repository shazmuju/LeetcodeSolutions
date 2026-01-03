public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
       HashSet <int> set=new HashSet<int>(nums1);
       HashSet <int> result=new HashSet<int>();

       foreach(int num in nums2){
        if(set.Contains(num)){
            result.Add(num);
        }
       }
       return result.ToArray();
    }
    
}