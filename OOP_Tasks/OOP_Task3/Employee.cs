abstract class Employee
{
    protected int id;
    protected string name;
    protected string address;
    protected float salary;
    
    public Employee()
    {
        id = -1;
        name = "";
        address = "";
        salary = 0;
    }
    
    public Employee(int id, string name, string address, float salary)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.salary = salary;
    }
    
    public int Id
    {
        get { return (id);}
    }
    
    public string Name 
    {
        get { return (name);}
    }
    
    public string Address 
    {
        set { address = value; }
        get { return (address); }
    }
    
    public float Salary 
    {
        set { salary = value; }
        get { return (salary); }
    }
    
    public abstract string printData();
}