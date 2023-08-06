class Employee:Person
{
    float salary;
    
    public Employee(int id, string name, float salary):base(id, name)
    {
        this.salary = salary;
    }
    
    public Employee(int id, string name, int age, float salary):base(id, name, age)
    {
        this.salary = salary;
    }
    
    public float Salary
    {
        set {salary = value;}
        get {return(salary);}
    }
    
    public float addSalary(float addition)
    {
        return (salary += addition);
    }
    
    public override string printData()
    {
        return ("employee id: " + id + "\n" + "employee name: " + name + "\n" + "employee salary: " + salary + "\n");
    }
}