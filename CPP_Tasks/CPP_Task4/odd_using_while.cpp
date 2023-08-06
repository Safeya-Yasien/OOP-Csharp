#include <iostream>
using namespace std;

int main()
{
    int i = 1;
    
    while (i <= 99)
    {
        if (i % 2 == 1)
            cout<<i<<' ';
        else
        {
            i++;
            continue;
        }
        i++;
    }
}

