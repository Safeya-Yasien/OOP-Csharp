#include <iostream>
using namespace std;

int main()
{
    for (int i = 1; i <= 99; i++)
    {
        if (i % 2 == 1)
            cout<<i<<' ';
        else
            continue;
    }
}

