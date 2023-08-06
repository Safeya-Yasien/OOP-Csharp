#include <iostream>
using namespace std;

int main()
{
    int sum;

    cout<<"enter your sum: ";
    cin>>sum;
    // double grade = (sum / 500) * 100;
    float grade = (float(sum) / 500) * 100;
    cout<<"grad is: "<<grade<<"%";
}
