public class Solution {
    public int MinOperations(IList<int> nums, int k) {
        int n=nums.Count;
        bool[] numbers=new bool[n+1];
        int count=0;

        for(int i=n-1;i>=0;i--){
            int x=nums[i];
            if(x>=1 && x<=k && numbers[x]==false){
                numbers[x]=true;
                count++;
            
            if(count==k){
                return n-i;
            }
            }
        }
        return -1;
    }
}