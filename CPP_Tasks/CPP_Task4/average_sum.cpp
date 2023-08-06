#include <iostream>
using namespace std;

int main()
{
    int num, sum = 0, count = 0;
    
    cout<<"enter a number: ";
    cin >> num;
    
    sum = num;
    count = 1;
    
    while(1)
    {
        cout<<"enter a number: ";
        cin >> num;
        
        if (num == 0)
            break;
        sum += num;
        count++;
    }
    
    cout<<"sum = "<<sum<<endl;
    cout<<"average = "<<sum / count;
    
    return (0);
}
