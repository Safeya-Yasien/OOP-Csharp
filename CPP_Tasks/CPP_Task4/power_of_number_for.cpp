#include <iostream>
using namespace std;

int main()
{
    int num, exp, re = 1;
    
    cout<<"enter number: ";
    cin>>num;
    
    cout<<"enter exponent: ";
    cin>>exp;
    
    for (int i = 1; i <= exp; i++)
        re *= num; 
    
    cout<<re;
}
