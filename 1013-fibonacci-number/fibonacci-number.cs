public class Solution {
    public int Fib(int n) {
     if(n<=1){
        return n;
     } 

     int [] fibn =new int[n+1];
     fibn[0]=0;
     fibn[1]=1;

     for(int i=2;i<=n;i++){
        fibn[i]=fibn[i-1]+fibn[i-2];
     }

     return fibn[n];
    }
}