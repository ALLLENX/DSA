public class Solution {
    public int CountPairs(IList<int> nums, int target) {
            /* Approach - using extreme Pair logic.towards each other ptr 
                1. Sort array .while(i<j)
                condition  - if (sum of extreme is smaller than target count all pair)
                        count = j-i;
                        i++
            
                else j--
            */
            int []arr = nums.ToArray();
            arr.Sort();
            int i = 0 ,j = arr.Length-1, count = 0;
            while(i<j){
                if(arr[i]+arr[j]<target){
                    count +=j-i;
                    i++;
                }
                else{
                    j--;
                }
            }
            return count;
            
            
    }
}