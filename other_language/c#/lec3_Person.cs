class Person
{
    protected int id;
    protected string name;
    protected int age;
    
    public Person()
    {
        
    }
    public Person(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public Person(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    
    public int Id
    {
        get { return id; }
    }
    
    public string Name
    {
        get {return(name);}
    }
    
    public int Age
    {
        set { age = value; }
        get { return age; }
    }
    
    public int yearOfBirth()
    {
        return(2023 - age);
    }
    
    public virtual string printData()
    {
        return ("person id: " + id + "\n" + "person name: " + name + "\n" + "person age: " + age + "\n");
    }
}