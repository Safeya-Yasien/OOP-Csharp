#include <iostream>
using namespace std;

int main()
{
    int num, fact = 1;
    
    cout<<"enter a number: ";
    cin>>num;
    
    while (num)
    {
        fact = fact * num;
        num--;
    }
    cout<<fact;
    
    return (0);
}
