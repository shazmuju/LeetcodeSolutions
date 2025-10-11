public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        int revnum=0;
        int num=x;
        while(x>0){
            revnum=revnum*10+x%10;
            x=x/10;
        }

    //   string s = x.ToString();
    //   string reversed = new string(s.Reverse().ToArray());
       return revnum == num;
    }
     
}