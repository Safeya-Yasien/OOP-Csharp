#include "Employee.h"


Employee::Employee(int id, string name, string address, float salary)
{
	this->id = id;
	this->name = name;
	this->address = address;
	this->salary = salary;
}

Employee::Employee()
{
	id = -1;
	name = "";
	address = "";
	salary = 0;
}

/// setter and getter

int Employee::getId()
{
	return (id);
}

string Employee::getName()
{
	return (name);
}

void Employee::setName(string name)
{
	this->name = name;
}

void Employee::setAddress(string address)
{
	this->address = address;
}

string Employee::getAddress()
{
	return (address);
}

void Employee::setSalary()
{
	this->salary = salary;
}

float Employee::getSalary()
{
	return (salary);
}

void Employee::printData()
{
	cout << "Employee id: " << id <<
		"\tEmployee name: " << name <<
		"\tEmployee address: " << address <<
		"\tEmployee salary: " << salary;
}
