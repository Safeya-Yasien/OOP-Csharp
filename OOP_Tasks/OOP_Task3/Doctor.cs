class Doctor:Employee
{
    int patientNumber;
    
    public Doctor(int id, string name, string address, float salary, int patientNumber):base(id, name, address, salary)
    {
        this.patientNumber = patientNumber;
    }
    
    public int patient_number
    {
        set { patientNumber = value; }
        get { return(patientNumber); }
    }
    
    public float additionSalary()
    {
        if (patientNumber > 10)
            return (salary += 2000);
        else if (patientNumber >= 5)
            return (salary += 1000);
        else
            return (salary);
    }
    
    public override string printData()
    {
        return ("doctor id: " + id + "\n" +
                "doctor name: " + name + "\n" +
                "doctor address: " + address + "\n" +
                "doctor salary: " + additionSalary() + "\n");
        
    }
}