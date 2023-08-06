#include <iostream>
#include <math.h>
using namespace std;

void square(int side);
void triangle(float a, float b, float c);
void circle(float r);


int main()
{
    char c;
    
    cout<<"enter char: ";
    cin>>c;
    
    int side;
    float x, y, z, r;
    
    switch (c)
    {
        case 'S':
            cout<<"side of square: ";
            cin>>side;
            square(side);
            break;
        case 'T':
            cout<<"Please Enter three sides of triangle\n";
            cin>>x>>y>>z;
            triangle(x, y, z);
            break;
        case 'C':
            cout<<"enter radius: ";
            cin>>r;
            circle(r);
            break;
        default:
            cout<<"not found";
    }
}

void square(int side)
{
    int area = side * side;
    int perimeter = (side) * 4;
    cout<<"area of square : "<<area<<endl;
    cout<<"perimter of square: "<<perimeter;
}

void triangle(float a, float b, float c)
{
    
    float perimeter, s, area;
       
    perimeter = a + b + c;
    s = (perimeter) / 2;
    area = sqrt(s * (s - a) * (s - b) * (s - c));
       
    cout<<"area is "<<area<<endl;;
    cout<<"perimeter is "<<perimeter<<endl;
}

void circle(float r)
{
    float area, perimter;

    area = 3.14 * (r * r);
    perimter = 2 * 3.14 * r;

    cout<<"area of circle: "<<area<<endl;
    cout<<"perimter of circle: "<<perimter;
}
