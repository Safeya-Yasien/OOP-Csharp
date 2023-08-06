#include <iostream>
using namespace std;

int main()
{
    int i = 1, j = 1;
    
    while (i <= 12)
    {
        cout<<"Table of "<<i<<endl;
        
        while (j <= 12)
        {
            cout<<i<<" * "<<j<<" = "<<i * j<<endl;
            j++;
        }
        cout<<"***********************************"<<endl;
        i++;
        j = 1;
    }
}

