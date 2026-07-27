public class Solution {
    public int Compress(char[] chars) {
        int n = chars.Length;

     int indx = 0;// keeps track of last ind of result array 
     int i=0 ; //traverse each element of array
     while(i<n){

             char curr_char = chars[i];// track current char .
             int count =0; // count frequency of each element .

             //find count of duplicate 
             while(i<n && curr_char ==chars[i]){
                count++;
                i++;
             }
             //count assignment 
             chars[indx] = curr_char;
             indx++;
             //if group leght is >10
             if (count>1){
                string s = count.ToString();
                foreach(var num in s){
                    chars[indx] = num;
                    indx++;
                }
             }

     }
    return indx;
    }
}