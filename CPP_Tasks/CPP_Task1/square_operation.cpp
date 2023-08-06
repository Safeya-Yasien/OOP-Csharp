#include <iostream>
using namespace std;

int main()
{
    // area = side * side
    // perimter = (side) * 4

    float side, area, perimeter;

    cout<<"enter side: ";
    cin>>side;

    area = side * side;
    perimeter = (side) * 4;

    cout<<"area of square : "<<area<<endl;
    cout<<"perimter of square: "<<perimeter;
}
