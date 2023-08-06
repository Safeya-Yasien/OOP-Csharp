class Students:Person
{
    float gpa;
    
    public Students(int id, string name, float gpa):base(id, name)
    {
        this.gpa = gpa;
    }
    
    public Students(int id, string name, int age, float gpa):base(id, name, age)
    {
        this.gpa = gpa;
    }
    
    public float Gpa
    {
        set {gpa = value;}
        get {return (gpa);}
    }
    
    public string calcEval()
    {
        if (gpa > 4 || gpa < 0)
            return ("Invalid");
        else if (gpa > 3)
            return ("Excellent");
        else if (gpa > 2)
            return ("Very Good");
        else
            return ("Not Passed");
    }
    
    public override string printData()
    {
        return ("student id: " + id + "\n" + "student name: " + name + "\n" + "student gpa: " + gpa + "\n" + "evaluation: " + calcEval() + "\n");
    }
}