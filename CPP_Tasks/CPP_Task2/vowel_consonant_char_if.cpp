#include <iostream>
using namespace std;

int main()
{
    char c;

    cout<<"enter char: ";
    cin>>c;

    if (c == 'a' || c == 'o' || c == 'i' || c == 'e' || c == 'u')
        cout<<"vowel char";
    else
        cout<<"consonant char";

}
