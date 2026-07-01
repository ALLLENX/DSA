public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        /*we need  2 pointer approach , l, r , r is iterated through array ,
            left for keeping ttack of previouse unique,
            if we encounter new element we put it in l index and ++ l index */
            int l = 1  ;//assuming 1st element uniques in sorted array
          
            for(int r = 1;r<nums.Length;r++){ //r ptr from 1st pos 
                if(nums[r] != nums[r-1]){ //if unique encountered swaps with l ind
                    nums[l]  = nums[r];
                    l++;
                }
            }
            return l;
}

}