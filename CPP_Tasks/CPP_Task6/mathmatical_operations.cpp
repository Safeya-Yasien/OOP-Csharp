#include <iostream>
#include "MyMath.h"
using namespace std;

int main()
{
        double a, b;

        cout<<"enter two numbers: ";
        cin>>a>>b;

        double result_sum = sum(a, b),
               result_sub = sub(a, b),
               result_mul = mul(a, b),
               result_div = div(a, b),
               result_mod = mod(a, b),
               result_pow = Pow(a, b);

        cout<<"sum: "<<result_sum<<endl;
        cout<<"sub: "<<result_sub<<endl;
        cout<<"multiplication: "<<result_mul<<endl;
        cout<<"division: "<<result_div<<endl;
        cout<<"modules: "<<result_mod<<endl;
        cout<<"power: "<<result_pow<<endl;

}

