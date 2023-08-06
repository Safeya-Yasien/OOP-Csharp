using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec4_T2
{
	abstract class Employee
	{
		protected int EmpID, EmpAge, NumberOfDays;
        protected float EmpSalary;
        protected string Name, Address, EmpGender;

		public Employee()
		{
			
		}
		public Employee(int EmpID, int EmpAge, int NumberOfDays, float EmpSalary, string Name, string Address, string EmpGender)
		{
			this.EmpID = EmpID;
			this.EmpAge = EmpAge;
			this.NumberOfDays = NumberOfDays;
			this.EmpSalary = EmpSalary;
			this.Name = Name;
			this.Address = Address;
			this.EmpGender = EmpGender;
		}

		public int emp_id
		{
			get { return (EmpID); }
		}

        public int emp_age
        {
			set { EmpAge = value; }
            get { return (EmpAge); }
        }
        public int number_of_days
        {
			set { NumberOfDays = value; }
            get { return (NumberOfDays); }
        }
        public float emp_salary
        {
			set { EmpSalary = value; }
            get { return (EmpSalary); }
        }
        public string name
        {
			set { Name = value; }
            get { return (Name); }
        }
        public  string address
        {
			set { Address = value; }
            get { return (Address); }
        }
		public string emp_gender
        {
            get { return (EmpGender); }
        }

		public abstract string PrintData();

		public abstract void CalcSalary();
    }
}
