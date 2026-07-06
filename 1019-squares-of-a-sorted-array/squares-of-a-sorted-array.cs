public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i = 0 ;
        int j = nums.Length - 1;
        int []res  = new int [nums.Length];
        int k = nums.Length -1;
        while(i<=j){
            if(Math.Pow(nums[i],2)< Math.Pow(nums[j],2)){
                res[k]  = (int)Math.Pow(nums[j],2);
                k--;
                j--;
            }
            else{
                res[k] = (int)Math.Pow(nums[i],2);
                k--;
                i++;
            }
        }
        return res;
    }
}