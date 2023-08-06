#include <iostream>
using namespace std;


int main()
{
    int n, arr[100];
    
    cout<<"enter number of elements: ";
    cin>>n;
    
    cout<<"enter elements of array: ";
    
    for (int i = 0; i < n; i++)
        cin>>arr[i];
    
    int temp = arr[n - 1];

    for (int i = n - 1; i > 0; i--)
        arr[i] = arr[i - 1];

    arr[0] = temp;
    
    for (int i = 0; i < n; i++)
        cout<<arr[i]<<" ";
    
}
