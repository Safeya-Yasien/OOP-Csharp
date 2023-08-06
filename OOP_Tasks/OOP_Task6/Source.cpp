#include <iostream>
#include <string>
#include "Employee.h"
#include "Doctor.h"
#include "Nurse.h"

using namespace std;

int main()
{
    int n = 1;
    int id, overtime, patient_number;
    string name, address, choice;
    float salary;

    while (true)
    {
        cout<<"Doctor or Nurse: ";
        cin >> choice;

        if (choice == "d" || choice == "doctor")
        {
            cout << "Enter Doctor" << n << " ID" << n << " : ";
            cin >> id;

            cout<<"Enter Doctor" << n << " name" << n << " : ";
            cin >> name;

            cout<<"Enter Doctor" << n << " address" << n << " : ";
            cin >> address;

            cout<<"Enter Doctor" << n << " patient number" << n << " : ";
            cin >> patient_number;

            cout<<"Enter Doctor" << n << " salary" << n << " : ";
            cin >> salary;

            Doctor d1(id, name, address, salary, patient_number);

            cout<<"Doctor" << n << " data: "<<endl;
            d1.printData();
            n++;

        }
        else if (choice == "n" || choice == "nurse")
        {
            cout<<"Enter Nurse" << n << " ID" << n << " : ";
            cin >> id;

            cout<<"Enter Nurse" << n << " name" << n << " : ";
            cin >> name;

            cout<<"Enter Nurse" << n << " address" << n << " : ";
            cin >> address;

            cout<<"Enter Nurse" << n << " overtime" << n << " : ";
            cin >> overtime;

            cout<<"Enter Nurse"<< n<<" salary" << n << " : ";
            cin >> salary;

            Nurse n1(id, name, address, salary, overtime);

            cout<<"Nurse" << n << " data: "<<endl;
            n1.printData();
            n++;
        }
        else
        {
            string flag = "no";

            cout<<"Invalid Choice"<<endl;
            cout<<"if you want to add another person enter yes: "<<endl;
            cin >> flag;

            if (flag != "yes")
            {
                break;
            }
        }
    }
}
