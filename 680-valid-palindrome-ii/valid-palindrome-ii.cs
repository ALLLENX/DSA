public class Solution {
    public bool PalinHelper(int i , int j , string s){
        while(i<j){
            if (s[i] != s[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    public bool ValidPalindrome(string s) {
        int i = 0 ;
        int j  = s.Length - 1;
        while(i<j){
            char left = s[i];
            char right = s[j];
            if(left != right ){
                // checking 1 time if we can make str palin after skipping either char
                return PalinHelper(i+1,j,s) || PalinHelper(i,j-1,s);
            }
            else{
                i++;
                j--;

            }
        }
        return true;
    }
}