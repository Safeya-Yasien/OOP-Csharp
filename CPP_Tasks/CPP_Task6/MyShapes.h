#include <iostream>
using namespace std;

void traingle()
{
    int n = 10;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i >= j)
                cout<<"* ";
        }
        cout<<'\n';
    }
}

void square()
{
    int n = 10;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            cout<<"* ";
        cout<<"\n";
    }
}

void rectangle()
{
    int row = 10, col = 5;

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
            cout<<"* ";
        cout<<endl;
    }
}

