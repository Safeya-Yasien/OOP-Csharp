#include <iostream>
using namespace std;


int main()
{
    int n, m, arr1[100], arr2[100], merge_arr[200], j = 0;
    
    cout<<"enter number of elements of array1: ";
    cin>>n;
    cout<<"enter array elements: ";
    for (int i = 0; i < n; i++)
    {
        cin>>arr1[i];
        merge_arr[j] = arr1[i];
        j++;
    }
    
    cout<<"enter number of elements of array2: ";
    cin>>m;
    cout<<"enter array elements: ";
    for (int i = 0; i < m; i++)
    {
        cin>>arr2[i];
        merge_arr[j] = arr2[i];
        j++;
    }
    
    for (int i = 0; i < j; i++)
    {
        cout<<merge_arr[i]<<" ";
    }
    
    
}
