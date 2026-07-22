public class Solution {
    public int LengthOfLastWord(string s) {
        int counter = 0 ;
        s = s.TrimEnd();
        for(int i =s.LastIndexOf(" ")+1;i<s.Length;i++){
            counter++;
        }
        return  counter;
    }
}