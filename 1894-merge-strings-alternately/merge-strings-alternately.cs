public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result="";
        int MaxLength=Math.Max(word1.Length,word2.Length);

        for(int i=0;i<MaxLength;i++){
            if(i<word1.Length){
                result+=word1[i];
            }
            if(i<word2.Length){
                result+=word2[i];
            }
        }

        return result;
    }
}