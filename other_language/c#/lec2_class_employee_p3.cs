namespace OOP_Lec2
{
    class Employee
    {
        int id;
        string name;
        int salary;

        /* 
            constructor
            ► should be public
            ► his name shoudl be the same name of the class
            ► not have a return type

        */

        /*
        public Employee()
        {
            // this is default values when user not input them
            id = 1;
            name = "unkown";
            salary = 1000;
        }
        */

        // but here id is uniq so not be duplicated so the user must enter it
        // we will pass id as a parameter in constructor and will be " إجباري "
        // if i want to name the parameter the same name as variable so we will use this

        public Employee(int id)
        {
            // this is default values when user not input them
            this.id = id;
            name = "unkown";
            salary = 1000;
        }

        // we can make options which means should send id and another option must send id and name
        // this way named constructor overload
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
            salary = 1000;
        }


        public int ID
        {
            set {id = value;}
            get {return (id);}
        }

        public string Name
        {
            set {name = value;}
            get {return (name);}
        }

        public int Salray
        {
            set {salary = value;}
            get {return (salary);}
        }
    }
}