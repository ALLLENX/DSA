public class Solution {
    public string ToLowerCase(string s) {
     char [] nums = s.ToCharArray();
     for (int i = 0 ; i<nums.Length;i++){
        if(nums[i]>='A'&& nums[i]<='Z'){
        nums[i] = (char)(nums[i]+32);
     }
     }
     return new string (nums);
}
}