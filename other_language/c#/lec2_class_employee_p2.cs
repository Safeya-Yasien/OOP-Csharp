namespace OOP_Lec2
{
    class Employee
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
        string name;
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
        
        public void SetName(string n)
        {
            name = n;
        }
        
        public string GetName()
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

        // but now we need to add two functions to access private variables
        // but this way for C# only proparties
        
        // the name id must be difference if variable is small make properity capital
        public int id
        {
            // we can write set only or write get only
            set {ID = value;}
            get {return (ID);}
        }

        public string NAME
        {
            set {name = value;}
            get {return (name);}
        }

        public int SALARY
        {
            set {salary = value;}
            get {return (salary);}
        }

    }
}