public class Solution {
    public bool CheckIfPangram(string sentence) {
        int [] arr = new int[26];
        int i =0;
        for(;i<sentence.Length;i++){
            arr[sentence[i]-'a'] = 1;
        }
        return arr.IndexOf(0)!= -1 ? false : true;
    }
}