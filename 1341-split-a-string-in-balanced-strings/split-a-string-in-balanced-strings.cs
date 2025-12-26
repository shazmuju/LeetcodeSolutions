public class Solution {
    public int BalancedStringSplit(string s) {
        int left=0;
        int right=0;
        int count=0;

        for(int i=0;i<s.Length;i++){
            if(s[i]=='L'){
                left++;
            }
            if(s[i]=='R'){
                right++;
            }
            if(left==right){
                count++;
            }
        }

        return count;
    }
}