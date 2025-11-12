public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
     IList<bool> Candylist=new List<bool>();
     int Maxcandies=candies.Max();
    for(int i=0;i<candies.Length;i++){
        if(candies[i]+extraCandies>=Maxcandies){
            Candylist.Add(true);
        }
      else{
           Candylist.Add(false);
      }
    }
    // foreach(int candy in candies){
    //     Candylist.Add(candy+extraCandies>=Maxcandies);
    // }
    return Candylist;
    }
}