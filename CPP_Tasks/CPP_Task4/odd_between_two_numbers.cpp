#include <iostream>
using namespace std;

int main()
{
    int a, b;
    
    cout<<"enter two numbers: ";
    cin>>a>>b;
    
    if (a == b)
    {
        cout<<"No numbers between a and b";
        return (0);
    }

    while (a < b)
    {
        if (a % 2 == 1)
            cout<<a<<' ';
        a += 2;
    }
    
    while (b < a)
    {
        if (a % 2 == 1)
            cout<<a<<' ';
        a -= 2;
    }
    
    return 0;
}
