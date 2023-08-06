#include <iostream>
using namespace std;


int main()
{
    int n = 5, arr[n];
    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
        cin>>arr[i];
    
    for (int i = n - 1; i >= 0; i--)
        cout<<arr[i]<<' ';
}
