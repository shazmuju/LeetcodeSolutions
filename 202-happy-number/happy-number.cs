    public class Solution {
    public bool IsHappy(int n) {
      HashSet<int> set=new HashSet<int>();

      while(n!=1){
        if(set.Contains(n)){
            return false;
        }
        set.Add(n);
        int sum=0;
        while(n>0){
            int digit=n%10;
           sum=sum+(digit*digit);
           n=n/10;
        }
        n=sum;
       
      }
      return true;
    }

}
