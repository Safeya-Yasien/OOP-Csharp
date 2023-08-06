// package oop_lec2;
// public class OOP_Lec2
public class Main
{
	public static void main(String[] args)
    {
        
        Employee e1 = new Employee();
        e1.SetID(1);
        e1.SetName("Ahmed");
        e1.SetSalary(1000);
        
        System.out.println(e1.GetID());
        System.out.println(e1.GetName());
        System.out.println(e1.GetSalary());
    }
    
}
