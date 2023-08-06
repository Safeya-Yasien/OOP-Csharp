// package oop_lec2;
// public class OOP_Lec2
public class Main
{
	public static void main(String[] args)
    {
        /*   
            such int x but int is integer will point to number
            but x is primitive variable
            and e1 is reference variable
        */
        
        // Employee e1;
        
        // create object it's copy of Employee
        // e1 = new Employee();
        
        // or we can make them in one line
        Employee e1 = new Employee();
        
        e1.name = "Mohamed";
        e1.salary = 3000;
        
        // if we have another employee
        Employee e2 = new Employee();
        e2.name = "Yasien";
        e2.salary = 4000;
        
        // if we add another element in class Employee?
        /*
            we add ID so you can modify the previous employees and add id to them
            but if we not add it?
            will put default value which = 0
        */
        Employee e3 = new Employee();
        e3.name = "Ahemd";
        e3.salary = 2000;
        e3.ID = 15;
        
        Employee e4 = new Employee();
        e4.name = "Sameh";
        e4.salary = 6000;
        e4.ID = 10;
        // salary will increase on this employee only so function effect on the 
        // employee which you call function with it
        e4.IncreaseSalary(500);
        
        // we can make object equal to another object and 
        // any effect of e5 will effect on e4
        Employee e5 = e1;
        e5.IncreaseSalary(1000);
        
        // to ensure from thes data was saved in memory
        System.out.println(e1.name);
        System.out.println(e1.ID);
        System.out.println(e2.salary);
        System.out.println(e3.ID);
        System.out.println(e4.salary);
        System.out.println(e1.salary);
    }
}