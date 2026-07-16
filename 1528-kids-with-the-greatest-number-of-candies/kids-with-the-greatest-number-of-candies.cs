public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int n = candies.Length;
        int maxe = candies.Max();
        IList<bool>resultar =  new List <bool>(n);
        foreach(var i  in candies ){
            if (i+extraCandies>=maxe){
                resultar.Add(true);
            }
            else{
                resultar.Add(false);
            }
        }
        return resultar;
    }
}