//Kadane's algorithm to find max sub array 
#include<iostream>
#include<vector>
#include<climits>
using namespace std;

int kadane(int n , vector<int>ar,vector<int>&res)
{
    vector<int> cur_ar;
    int max_sum=INT_MIN;
    int cur_sum=0;
    
    for(int i:ar)
    {
        cur_sum +=i;
        cur_ar.push_back(i);
        if(cur_sum>max_sum)
        {
            max_sum=cur_sum;
            res = cur_ar;7
            
        }
        if(cur_sum<0)
        {
        cur_sum=0;
        cur_ar.clear();
        }
    }
    return (max_sum);
}
int main ()
{
    int n , i=0 ;
    cout<<"Size of array >\n";
    cin>>n;
    vector<int> arr;
    vector<int>res;
    cout<<"Enter values.\n";
    for(;i<n;i++)
    {
        int temp=0;
        cin>>temp;
        arr.push_back(temp);
    }
    int num = kadane(n,arr,res);
    cout<<"\nMaximum sum = "<<num;
    cout<<"\nResulting subarray: ";
    for(int i:res)
    {
        cout<<endl<<i<<" ";
    }
    return 0;
}
