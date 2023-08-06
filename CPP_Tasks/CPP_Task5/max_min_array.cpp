#include <iostream>
using namespace std;


int main()
{
    int n, arr[100], max, min;
    
    cout<<"enter number of elements in array: ";
    cin>>n;
    
    arr[n];
    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
        cin>>arr[i];
    
    max = arr[0];
    min = arr[0];
    
    for (int i = 1; i < n; i++)
    {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
    }
    
    cout<<"max element: "<<max<<endl;
    cout<<"min element: "<<min;
    
}
