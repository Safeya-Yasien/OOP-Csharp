#include <iostream>
using namespace std;


int main()
{
    int n, m, arr1[100], arr2[100], flag = -1;
    
    cout<<"enter number of elements of array1: ";
    cin>>n;
    cout<<"enter array elements: ";
    for (int i = 0; i < n; i++)
        cin>>arr1[i];
    
    cout<<"enter number of elements of array2: ";
    cin>>m;
    cout<<"enter array elements: ";
    for (int i = 0; i < m; i++)
        cin>>arr2[i];
    
    if (n != m)
        cout<<"not identical";
    else
    {
        for (int i = 0; i < n && i < m; i++)
        {
            if (arr1[i] != arr2[i])
            {
                flag = 0;
                break;
            }
        }
        if (flag == 0)
            cout<<"not identical";
        else
            cout<<"indentical";
    }
    
    
}
