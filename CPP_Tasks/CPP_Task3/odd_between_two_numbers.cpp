#include <iostream>
#include <math.h>
using namespace std;


int main()
{
    int a, b, s;

    cout<<"enter two numbers: ";
    cin>>a>>b;

    if (b > a)
    {
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 1)
                cout<<i<<' ';
        }
    }
    else if (a > b)
    {
        for (int i = a; i >= b; i--)
        {
            if (i % 2 == 1)
                cout<<i<<' ';
        }
    }
    else
        cout<<"No numbers between a adn b";


}
