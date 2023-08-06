#include <iostream>
using namespace std;

int main()
{
    int num;
    
    cout<<"enter number: ";
    cin>>num;
    
    int i = 0;
    
    while (i <= 12)
    {
        cout<<num<<" * "<<i<<" = "<<num * i<<endl;
        i++;
    }
    
    return (0);
}
