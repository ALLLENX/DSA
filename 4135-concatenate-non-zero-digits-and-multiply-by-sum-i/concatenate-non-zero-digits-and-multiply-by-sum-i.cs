public class Solution {
    public long SumAndMultiply(int n) {
        long sum  =0, x =0 ;
        int i = 0;
        while(n>0){
            int temp = n % 10; // last digit of ne gets appended in temp
            sum += temp;     
             n/=10;  // updating value of n every time 
            if(temp !=0){
                 x += temp *(int) Math.Pow(10,i++);
            }
        }
        return  sum *x;
    }
}