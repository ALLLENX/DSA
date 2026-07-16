public class Solution {
    public int SecondHighest(string s) {
        int n = s.Length;
        int largest = Int32.MinValue;
        int sec_largest = Int32.MinValue;
        for(int i =0 ; i<n;i++){
            if (char.IsDigit(s[i])){
                int num = s[i]-'0';
                    if(num>largest){
                        sec_largest = largest;
                        largest = num;
                    }
                    else if (num>sec_largest && num !=largest){
                        sec_largest = num;
                    }
            }
        }
        return sec_largest == Int32.MinValue ? -1 : sec_largest;
    }
}