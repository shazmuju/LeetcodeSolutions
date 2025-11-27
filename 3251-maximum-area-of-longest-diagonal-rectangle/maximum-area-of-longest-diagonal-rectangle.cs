public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        long maxdiaglen=0;
        int maxarea=0;

        foreach(var rect in dimensions){
            long length=rect[0];
            long width=rect[1];

         long diaglen=(long)length*length+(long)width*width;
         int area=(int)length*(int)width;


         if(diaglen>maxdiaglen){
           maxdiaglen=diaglen;
           maxarea=area; 
         }
         else if(diaglen==maxdiaglen){
             maxarea=Math.Max(maxarea,area);
         }
        }
        return maxarea;
    }
}