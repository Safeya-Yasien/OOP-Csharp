#include <iostream>
using namespace std;

int main()
{
    char c;

    cout<<"enter char: ";
    cin>>c;

    switch (c)
    {
        case 'a':
        case 'o':
        case 'i':
        case 'e':
        case 'u':
            cout<<"vowel char";
            break;
        default:
            cout<<"consonant char";
    }
}
