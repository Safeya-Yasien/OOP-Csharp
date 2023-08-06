#pragma once
#include <iostream>

#include <string>
#include "Nurse.h"


Nurse::Nurse(int id, string name, string address, float salary, int overTime) 
	:Employee(id, name, address, salary)
{
	this->overTime = overTime;
}

Nurse::Nurse() :Employee()
{
	overTime = 0;
}

void Nurse:: setOverTime(int overTime)
{
	this->overTime = overTime;
}

int Nurse:: getOverTime()
{
	return (overTime);
}

float Nurse:: addOverTime()
{
	return (salary += (overTime * 500));
}

void Nurse:: printData()
{
	cout << "Nurse id: " << id <<
		"\tNurse name: " << name <<
		"\tNurse address: " << address <<
		"\tOverTime hours: " << overTime <<
		"\tNurse salary: " << addOverTime();
}