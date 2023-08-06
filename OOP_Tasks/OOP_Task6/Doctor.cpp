#pragma once
#include <iostream>
#include "Doctor.h"


Doctor::Doctor(int id, string name, string address, float salary, int patientNumber) 
	:Employee(id, name, address, salary)
{
	this->patientNumber = patientNumber;
}

Doctor::Doctor() : Employee()
{
	patientNumber = 0;
}

void Doctor::setPatientNumber(int patientNumber)
{
	this->patientNumber = patientNumber;
}

int Doctor::getPatientNumber()
{
	return (patientNumber);
}

float Doctor::addSalary(float salary)
{
	if (patientNumber >= 10)
		return (salary += 2000);
	else if (patientNumber >= 5)
		return (salary += 1000);
	else
		return (salary);
}

void Doctor::printData()
{
	cout << "Doctor id: " << id <<
	"\tDoctor name: " << name <<
	"\tDoctor address: " << address <<
	"\tPatient Number: " << patientNumber <<
	"\tDoctor salary: " << addSalary(salary) << endl;
}
