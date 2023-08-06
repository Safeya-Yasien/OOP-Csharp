#pragma once
#include "Employee.h"
#include <string>


class Doctor:Employee
{
	int patientNumber;

public:

	Doctor(int id, string name, string address, float salary, int patientNumber);
	Doctor();
	void setPatientNumber(int patientNumber);
	int getPatientNumber();
	float addSalary(float salary);
	void printData() override;
};