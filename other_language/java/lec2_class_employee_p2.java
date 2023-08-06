// package oop_lec2;
public class Employee
{
    /*
        if we delete public word will be default = private
        we have two options
            ► public
            ► private: we can use variabel or functions in this class
                we can't access them from another class
                
            The best in OOP using private variabels
            The best in OOP using public functions
            
            ○ so we will make function for every variabel to set value to it
            ○ so we will make function to set value to variabel
            ○ so we will make function to get it's value
        
    */
    
    int ID;
    String name;
    int salary;
    
    // set value to variabel
    public void SetID(int i)
    {
        ID = i;
    }
    
    // get value from variabel
    public int GetID()
    {
        return (ID);
    }
    
    public void SetName(String n)
    {
        name = n;
    }
    
    public String GetName()
    {
        return (name);
    }
    
    public void SetSalary(int s)
    {
        salary = s;
    }
    
    public int GetSalary()
    {
        return (salary);
    }
}