#include <iostream>
using namespace std;

int main()
{
    int num, exp, re = 1;
    
    cout<<"enter number: ";
    cin>>num;
    
    cout<<"enter exponent: ";
    cin>>exp;
    
    while (exp > 0)
    {
        re *= num;
        exp--;
    }
    
    cout<<re;
}
