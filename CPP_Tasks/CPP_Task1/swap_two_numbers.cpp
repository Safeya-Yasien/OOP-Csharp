#include <iostream>
using namespace std;

int main()
{
    int num1, num2, temp;

    cout<<"fisrt number: ";
    cin>>num1;

    cout<<"second number: ";
    cin>>num2;

    cout<<"before swap\nnum1 = "<<num1<<"\nnum2 = "<<num2<<endl;

    temp = num1;
    num1 = num2;
    num2 = temp;

    cout<<"after swap\nnum1 = "<<num1<<"\nnum2 = "<<num2<<endl;
}
