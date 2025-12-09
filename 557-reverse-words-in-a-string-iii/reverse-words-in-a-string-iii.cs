public class Solution {
    public string ReverseWords(string s) {
       string[] words=s.Split(' ');

       for(int i=0;i<words.Length;i++){
        char[] arr=words[i].ToCharArray();
        Array.Reverse(arr);
        string Reversed=new string(arr);
        words[i]=Reversed;
       }

       return String.Join(" ",words);


    }
}