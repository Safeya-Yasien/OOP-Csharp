#include <iostream>
using namespace std;

int main()
{
    int age;

    cin>>age;

    if (age > 3 && age <= 17)
        cout<<"Young";
    else if (age > 17 && age <= 40)
        cout<<"Adult";
    else if (age > 40 && age <= 100)
        cout<<"Old";
}
