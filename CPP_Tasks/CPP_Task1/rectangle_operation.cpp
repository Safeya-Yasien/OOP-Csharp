#include <iostream>
using namespace std;

int main()
{
    // area = length * width
    // perimter = (length + width) * 2

    float length, width, area, perimeter;

    cout<<"enter length: ";
    cin>>length;

    cout<<"enter width: ";
    cin>>width;

    area = length * width;
    perimeter = (length + width) * 2;

    cout<<"area of rectangle: "<<area<<endl;
    cout<<"perimter of rectangle: "<<perimeter;
}
