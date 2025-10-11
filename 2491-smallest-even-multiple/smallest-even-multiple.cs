public class Solution {
    public int SmallestEvenMultiple(int n) {
        int result;
       if(n%2==0){
        result=n;
       }
       else{
        result=2*n;
       }
       return result;

       
    }
}