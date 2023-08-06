#include <iostream>
using namespace std;

int main()
{
    char c, flag = 'T';
    int a, b;

    while (1)
    {
        cout<<"enter first number: ";
        cin>>a;

        cout<<"enter operation: ";
        cin>>c;

        cout<<"enter second number: ";
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
                cout<<"mult is "<< a * b<<endl;
                break;
            case '/':
                cout<<"div is "<< a / b<<endl;
                break;
            case '%':
                cout<<"mod is "<<a % b<<endl;
                break;
            default:
                cout<<"wrong choice"<<endl;
        }
        cout<<"enter T to press another operation: ";
        cin>>flag;

        if (flag != 'T')
            break;
    }
}
