public class Solution {
    public int MaximumLengthSubstring(string s) {
        int left=0;
        int maxlen=0;
       
       Dictionary<char,int>freq=new Dictionary<char,int>();

       for(int right=0;right<s.Length;right++){
        char currentchar=s[right];

        if(!freq.ContainsKey(currentchar)){
            freq[currentchar]=0;
        }
        freq[currentchar]++;

        while(freq[currentchar]>2){
            char leftchar=s[left];
            freq[leftchar]--;
            left++;
        }
        maxlen=Math.Max(maxlen,right-left+1);
       }

       return maxlen;
    }
}