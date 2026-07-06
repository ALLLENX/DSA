public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0 ;
        int [] res= new int [2];
        int j  = numbers.Length-1;
        while(numbers[i]+numbers[j]!=target){
            if(numbers[i]+numbers[j]<target){
                i++;
            }
            else{
                j--;
            }
        }
        res[0] = i+1;
        res[1] = j+1;
        return res;
    }
}