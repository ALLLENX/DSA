//checking if the array is sorted , using recursion
#include<bits/stdc++.h>
using namespace std;
bool issorted(vector<int>arr,int n)
{
    if(n==0||n==1) return true;
    
    else
    return (arr[n-1]>=arr[n-2])&&issorted(arr,n-1);
}
int main()
{
    vector<int>arr = {1,4,2,3,4,5};
    int n = arr.size();
    cout<<"the  given  array is sorted ?:";
    cout<<issorted(arr,n);
    return 0;
}
