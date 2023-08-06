#include <iostream>
#include <math.h>
using namespace std;


int main()
{
    int n;
    cin>>n;
    
    if (n % 3 == 0)
        cout<<n<<" is divisible by 3";
    else
        cout<<n<<" isn't divisible by 3";
}
