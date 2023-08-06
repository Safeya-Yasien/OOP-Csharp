#include <iostream>
using namespace std;

int main()
{
    char c;
    
    cout<<"enter char: ";
    cin>>c;
    
    switch (c)
    {
        case 'r':
            cout<<"Red";
            break;
        case 'y':
            cout<<"Yellow";
            break;
        case 'b':
            cout<<"Blue";
            break;
        default:
            cout<<"not found";
    }
}
