public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
       string result1=String.Join("",word1);
       string result2=String.Join("",word2);

       if(result1==result2){
        return true;
       }
       return false;
    }
}