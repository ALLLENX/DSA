public class Solution {
    public string CountAndSay(int n) {
        //base case 
        if (n==1)
            return "1";
        string say  = CountAndSay(n-1);
        //processing for non n==1 recursive call , i.e counting ,appneding count and char in res str
        string res = "";
        for(int i =0 ;i <say.Length;i++){
            char ch = say[i];
            int count = 1;
            while(i<say.Length-1 && ch ==say[i+1]){
                count++;
                i++;
            }
            res += count.ToString()+ ch;
        }
        return res;
    }
}