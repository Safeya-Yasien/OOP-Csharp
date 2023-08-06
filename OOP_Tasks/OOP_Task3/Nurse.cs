class Nurse:Employee
{
    float overTime;
    
    public Nurse()
    {
        
    }
    
    public Nurse(int id, string name, string address, float salary, float overTime):base(id, name, address, salary)
    {
        this.overTime = overTime;
    }
    
    public float over_time
    {
        set { overTime = value; }
        get { return(overTime); }
    }

    // add 500 on each hour
    public float additionSalary()
    {
        return (salary += (500 * overTime));
    }
    
    public override string printData()
    {
        return ("nurse id: " + id + "\n" +
                "nurse name: " + name + "\n" +
                "nurse address: " + address + "\n" +
                "nurse salary: " + additionSalary() + "\n");
        
    }
}