import java.time.LocalDateTime;

    class Student extends Person
    {
        static int count = 0;
        String code;
        Department dpt;
        Doctor supervisor;
        Subject[] subjects;

        public Student(String nationalID, String name)
        {
            super(nationalID, name) ;
            
            LocalDateTime now = LocalDateTime.now();
            String y = Integer.toString(now.getYear());
            String serial = String.format("%04d", ++count);
            String code = y + serial;

            dpt = null;
            supervisor = null;
            subjects = null;
        }

        public Student(String nationalID, String name, Department dpt, Doctor supervisor)
        {
            super(nationalID, name);
            
            LocalDateTime now = LocalDateTime.now();
            String y = Integer.toString(now.getYear());
            String serial = String.format("%04d", ++count);
            String code = y + serial;

            this.dpt = dpt;
            this.supervisor = supervisor;
            subjects = null;
        }


        public String getCode()
        {
            return (code);
        }
        
        public void setDpt(Department dpt)
        {
            this.dpt = dpt;
        }
        
        public Department getdpt()
        {
            return (dpt);
        }

        public void setSupervior(Doctor supervisor)
        {
            this.supervisor = supervisor;
        }
        
        public Doctor getSupervisor()
        {
            return supervisor;
        }
        
        public void setSubjects(Subject[] subjects)
        {
            this.subjects = subjects;
        }
        
        public Subject[] getSubjects()
        {
            return subjects;
        }

        public int getTotalHours()
        {
                int sum = 0;

                for (Subject s : subjects)
                    sum += s.getSubjectHours();

                return (sum);
        }

        public String toString()
        {
            return (name);
        }
        

        public void AddSubject(Subject s)
        {
            int n = subjects.Length;
            Subject[] temp = new Subject[n + 1];

            System.arraycopy(subjects, 0, temp, 0, n);
            temp[n] = s;
            subjects = temp;
        }


        public int getTotalSubjectHours()
        {
            int sum = 0;

            for (int i = 0; i < subjects.length; i++)
                sum += subjects[i].getSubjectHours();

            return (sum);
        }
    }
