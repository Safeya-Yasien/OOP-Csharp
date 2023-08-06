
    class Employee extends Person
    {
        int salary;
        String job;

        public Employee(String nationalID, String name, int salary, String job)
        {
            super(nationalID, name);
            this.salary = salary;
            this.job = job;
        }
    }

