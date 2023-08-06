#include <iostream>
using namespace std;


int main()
{
    int n = 5, arr[n], sum = 0;
    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
    {
        cin>>arr[i];
        sum += arr[i];
    }
    
    cout<<"sum is "<<sum<<endl;
    cout<<"average is "<<sum / n;
    
}
