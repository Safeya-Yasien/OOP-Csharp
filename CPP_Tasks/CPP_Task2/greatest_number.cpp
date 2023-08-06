#include <iostream>
using namespace std;

int main()
{
    int a, b, c, g;

    cout<<"first number: ";
    cin>>a;

    cout<<"second number: ";
    cin>>b;

    cout<<"third number: ";
    cin>>c;

    if (a > b && a > c)
        g = a;
    else if (b > a && b > c)
        g = g;
    else
        g = c;

    cout<<"greatest number: "<<g;
}
