#include <iostream>
using namespace std;

int main()
{
    char c;
    int a, b;

    cout<<"first number: ";
    cin>>a;

    cout<<"operation (+, -, *, /, $): ";
    cin>>c;

    cout<<"second number: ";
    cin>>b;

    switch (c)
    {
        case '+':
            cout<<"sum is "<<a + b<<endl;
            break;
        case '-':
            cout<<"sub is "<<a - b<<endl;
            break;
        case '*':
            cout<<"multi is "<<a * b<<endl;
            break;
        case '/':
            cout<<"div is "<< a / b<<endl;
            break;
        case '%':
            cout<<"mod is "<<a % b<<endl;
            break;
        default:
            cout<<"invalid choice";
    }
}
