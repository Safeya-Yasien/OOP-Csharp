#pragma once
#include <iostream>
#include <string>
#include "Employee.h"


class Nurse:Employee
{
	int overTime;

public:

	Nurse(int id, string name, string address, float salary, int overTime);
	Nurse();
	void setOverTime(int overTime);
	int getOverTime();
	float addOverTime();
	void printData() override;
};