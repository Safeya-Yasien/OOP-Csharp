#include <iostream>
using namespace std;

int main()
{
    // T (K) = T (°C) + 273.15.

    float celsius, kelvin;
    cout<<"Enter celsius degree: ";
    cin>>celsius;

    kelvin = celsius + 273.15;

    cout<<"Kelvin degree: "<<kelvin;
}
