#include <iostream>
using namespace std;

int main()
{
    int a = 0;
    
    while (a <= 50)
    {
        if (a % 3 == 0)
            cout<<a<<' ';
        a++;
    }
    
    return (0);
}
