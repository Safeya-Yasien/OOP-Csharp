#include <iostream>
using namespace std;

int main()
{
        /*
            static allocation which means the size of array must
            be constant
            what if we want to take size of array from user?
            will create dynamic allocation by using pointer

            int n;
            int *arr = new int[n];

        */

        const int n = 5;
        int arr[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = (i + 1) * 10;
            sum += arr[i];
        }

        cout<<"sum: "<<sum;

}
