public class Solution {
    public string ReverseStr(string s, int k) {
        char [] nums = s.ToCharArray();
        for(int i = 0 ; i <s.Length;i +=2*k){
                int st = i;
            int j =Math.Min(i+k-1,nums.Length-1);
            while(st<j){
                (nums[st],nums[j]) = (nums[j],nums[st]);
                st++;
                j--;
            }
        }
        return new string(nums);
    }
}