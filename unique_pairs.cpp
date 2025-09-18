//Printing all the unique pairs of an array 
#include<iostream>
using namespace std;
 int main ()
 {
     int arr[] ={2,7,11,5};
     int n = sizeof(arr)/sizeof(int);
     for(int i = 0;i<n;i++)
     {
         for(int j = i+1;j<n;j++)
         {
             cout<<"["<<arr[i]<<","<<arr[j]<<"] ";
         }
         cout<<endl;
         
     }
 }
