#include <iostream>
#include <math.h>
using namespace std;


int main()
{
    int num, sum, count;

    cout<<"enter number: ";
    cin>>num;

    sum = num;
    count = 1;

    while (num != 0)
    {
        cout<<"enter number: ";
        cin>>num;

        sum += num;
        count++;
    }

    cout<<"sum is "<<sum<<endl;
    cout<<"average is "<<sum / count<<endl;

}

