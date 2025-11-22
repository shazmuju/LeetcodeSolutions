public class Solution {
    public int MySqrt(int x) {

        int l=1;
        int r=x;

        while(l<=r){
          long mid=l+(r-l)/2;
          long squre=mid*mid;
          if(squre==x){
            return (int)mid;
          }
          else if(squre>x){
            r=(int)mid-1;
          }
          else{
            l=(int)mid+1;
          }
        }
        return r;
    }
}