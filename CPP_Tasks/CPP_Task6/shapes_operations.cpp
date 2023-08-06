#include <iostream>
#include "MyShapes.h"
using namespace std;

int main()
{
        char shape, choice;

        cout<<"enter shape: ";
        cin>>shape;

        while (1)
        {
            switch (shape)
            {
            case 't':
                traingle();
                break;
            case 's':
                square();
                break;
            case 'r':
                rectangle();
                break;
            default:
                cout<<"Invalid choice"<<endl;
            }
            cout<<"enter T to continue: ";
            cin>>choice;

            if (choice != 'T')
                break;

            cout<<"enter shape: ";
            cin>>shape;

        }
}

