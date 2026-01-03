public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
     Dictionary <char,int> lettercount=new Dictionary<char,int>();

     foreach(char c in magazine){
        if(lettercount.ContainsKey(c)){
            lettercount[c]++;
        }
        else{
            lettercount[c]=1;
        }
     }

     foreach(char c in ransomNote){
        if(!lettercount.ContainsKey(c) || lettercount[c]==0){
            return false;
        }
        lettercount[c]--;
     }
     return true;
    }
}