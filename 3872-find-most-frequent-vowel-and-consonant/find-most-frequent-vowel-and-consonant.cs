public class Solution {
    public int MaxFreqSum(string s) {
       Dictionary<char,int> lettrfreq=new Dictionary<char,int>();
       foreach(char c in s){
        if(lettrfreq.ContainsKey(c)){
            lettrfreq[c]++;
        }
        else{
            lettrfreq[c]=1;
        }
       }

        HashSet<int> vowels=new HashSet<int>{'a','e','i','o','u'};
        int maxvowel=0;
        int maxconsonents=0;

        foreach(var Keyvalues in lettrfreq){
            char letter=Keyvalues.Key;
            int count=Keyvalues.Value;

            if(vowels.Contains(letter)){
                 maxvowel=Math.Max(maxvowel,count);
            }
            else{
                maxconsonents=Math.Max(maxconsonents,count);
            }
        }

       
      return maxvowel + maxconsonents;
       
    }
}