#include <iostream>
using namespace std;

int main()
{
    int n, sum = 0;

    cout<<"enter number: ";
    cin>>n;

    for (int i = 1; i <= n; i++)
        sum += i;

    cout<<"sum is: "<<sum;
}
