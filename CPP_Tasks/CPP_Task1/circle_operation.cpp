#include <iostream>
using namespace std;

int main()
{
    // area = πr²
    // perimter = 2πr

    float r, area, perimter;
    cout<<"enter radius: ";
    cin>>r;

    area = 3.14 * (r * r);
    perimter = 2 * 3.14 * r;

    cout<<"area of circle: "<<area<<endl;
    cout<<"perimter of circle: "<<perimter;
}
