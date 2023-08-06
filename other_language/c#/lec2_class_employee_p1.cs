namespace OOP_Lec2
{
    class Employee
    {
        /*
            any class have three 
            ► his name
            ► data which is defined with variables
            ► behaviour which means functions
        */
        
        
        // so each employee has name and it's salary
        public string name;
        public int salary;
        public int ID;
        
        // we can add functions here
        public void IncreaseSalary(int s)
        {
            salary += s;
        }
        
    }
}