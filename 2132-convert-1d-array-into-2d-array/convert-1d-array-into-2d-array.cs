public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(original.Length!=m*n){
            return new int[0][];
        }
        //jagged array
        int[][] res=new int[m][];
        for(int row=0;row<m;row++){
            res[row]=new int[n];
        }
        int i=0,j=0;
        foreach(int num in original){
            res[i][j]=num;
            j++;
            if(j>=n){
                j=0;
                i++;
            }
        }
        return res;
    }
}