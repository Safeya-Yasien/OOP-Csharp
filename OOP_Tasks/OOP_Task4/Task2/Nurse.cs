using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec4_T2
{
    internal class Nurse: Employee
    {
        int OverTime;

        public Nurse(int EmpID, int EmpAge, int NumberOfDays, float EmpSalary, string Name, string Address, string EmpGender, int OverTime) : base(EmpID, EmpAge, NumberOfDays, EmpSalary, Name, Address, EmpGender)
        {
            this.OverTime = OverTime;
        }

        public int over_time
        {
            set { OverTime = value; }
            get { return OverTime; }
        }

        // public override float CalcSalary()
        public override void CalcSalary()
        {
            if (NumberOfDays >= 4 && NumberOfDays <= 6)
                //return (1000);
                EmpSalary = 1000;
            else if (NumberOfDays < 4)
                // return (400);
                EmpSalary = 400;
            // still condition
        }

        public float AddOverTime()
        {
            return (EmpSalary += (50 * OverTime));
        }

        public override string PrintData()
        {
            return
                (
                "Nurse Id: " + EmpID + "\t" +
                "Nurse Name: " + Name + "\t" +
                "Nurse Age: " + EmpAge + "\t" +
                "Nurse Adress: " + Address + "\t" +
                "Gender: " + EmpGender + "\t" +
                "Number of Days: " + NumberOfDays + "\t" +
                "OverTime Hours: " + OverTime + "\t" +
                "Nurse Salary: " + EmpSalary + "\t"
                );
        }
    }
}
