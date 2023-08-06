#pragma once
#include<iostream>
#include <string>
using namespace std;


class Employee
{

protected:
	int id;
	string name;
	string address;
	float salary;

public:
	Employee(int id, string name, string address, float salary);
	Employee();

	/// setter and getter
	int getId();
	string getName();
	void setName(string name);
	void setAddress(string address);
	string getAddress();
	void setSalary();
	float getSalary();
	virtual void printData();
};

