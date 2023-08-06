#include <iostream>
#include <math.h>
using namespace std;


int main()
{
    int num, fact = 1;
    
    cout<<"enter number: ";
    cin>>num;
    
    for (int i = 1; i <= num; i++)
        fact = fact * i;
    
    cout<<"fact of "<<num<<" is "<<fact;
    
}

