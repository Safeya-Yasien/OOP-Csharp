import java.time.LocalDateTime;

    class Doctor extends Person
    {
        Department dpt;
        LocalDateTime DateOfHiring;

        public Doctor(String nationalID, String name, LocalDateTime DateOfHiring)
        {
            super(nationalID, name);
            this.DateOfHiring = DateOfHiring;
            dpt = null;
        }

        public void setDept(Department dpt)
        {
            this.dpt = dpt;
        }
        
        public Department getDept()
        {
            return (dpt);
        }

        public void setDateOfHiring(LocalDateTime DateOfHiring)
        {
            this.DateOfHiring = DateOfHiring;
        }
        
        public LocalDateTime getDateOfHiring()
        {
            return (DateOfHiring);
        }

    }

