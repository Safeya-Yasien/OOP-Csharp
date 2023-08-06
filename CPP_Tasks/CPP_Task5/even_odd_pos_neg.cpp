#include <iostream>
using namespace std;


int main()
{
    int n = 10, arr[n], even = 0, odd = 0, pos = 0, neg = 0, zer = 0;

    cout<<"enter array elements: ";
    
    for (int i = 0; i < n; i++)
    {
        cin>>arr[i];
        
        if (arr[i] % 2 == 0)
            even++;
        else
            odd++;
        
        if (arr[i] > 0)
            pos++;
        else if (arr[i] < 0)
            neg++;
        else
            zer++;
    }
    
    cout<<"even numbers = "<<even<<endl;
    cout<<"odd numbers = "<<odd<<endl;
    cout<<"postive numbers = "<<pos<<endl;
    cout<<"negative numbers = "<<neg<<endl;
    cout<<"number of zeros = "<<zer<<endl;
}
