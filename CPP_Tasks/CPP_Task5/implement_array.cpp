#include <iostream>
using namespace std;


int main()
{
    int n = 5, arr[n];
    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
        cin>>arr[i];
    
    for (int i = 0; i < n; i++)
        cout<<arr[i]<<' ';
}
