#include <iostream>
using namespace std;


int main()
{
    int n = 5, arr[n], search, flag = 1;

    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
        cin>>arr[i];
        
    cout<<"enter a number: ";
    cin>>search;
    
    for (int i = 0; i < n; i++)
    {
        if (search == arr[i])
        {
            flag = 0;
            break;
        }
    }
    
    if (flag == 0)
        cout<<"found";
    else
        cout<<"not found";
}
