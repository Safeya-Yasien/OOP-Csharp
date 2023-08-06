using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec4_T2
{
    internal class Doctor:Employee
    {
        int ExperienceYears, PatientNumber;

        public Doctor(int EmpID, int EmpAge, int NumberOfDays, float EmpSalary, string Name, string Address, string EmpGender, int ExperienceYears, int PatientNumber):base(EmpID, EmpAge, NumberOfDays, EmpSalary, Name, Address, EmpGender)
        {
            this.ExperienceYears = ExperienceYears;
            this.PatientNumber = PatientNumber;
        }

        public int experience_years
        {
            set { ExperienceYears = value; }
            get { return ExperienceYears; }
        }

        public int patient_number
        {
            set { PatientNumber = value; }
            get { return PatientNumber; }
        }

        public override void CalcSalary()
        {
            if ((ExperienceYears >= 5 && ExperienceYears <= 10)
                && (PatientNumber >= 10 && PatientNumber <= 20)
                && (NumberOfDays >= 3 && NumberOfDays <= 6))
                EmpSalary = 2000;
            else if (ExperienceYears > 10)
                EmpSalary = 2500;
        }

        public void SetNoPatient()
        {
            if (PatientNumber > 20)
                PatientNumber = 20;
            else if (PatientNumber < 10)
                PatientNumber = 10;
        }

        public void SetExperience()
        {
            if (ExperienceYears > 20)
                ExperienceYears = 20;
            else if (ExperienceYears < 10)
                ExperienceYears = 10;
        }

        public void SetNoDays()
        {
            if (NumberOfDays > 6)
                NumberOfDays = 6;
            else if (NumberOfDays < 3)
                NumberOfDays = 3;
        }

        public override string PrintData()
        {
            return
                (
                "Doctor Id: " + EmpID + "\t" +
                "Doctor Name: " + Name + "\t" +
                "Doctor Age: " + EmpAge + "\t" +
                "Doctor Adress: " + Address + "\t" +
                "Gender: " + EmpGender + "\t" +
                "Number of Days: " + NumberOfDays + "\t" +
                "Patient Number: " + PatientNumber + "\t" +
                "Experience Years: " + ExperienceYears + "\t" +
                "Doctor Salary: " + EmpSalary + "\t"
                );
        }

    }
}
