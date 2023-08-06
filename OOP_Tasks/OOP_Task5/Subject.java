

    class Subject
    {
        String SubjectCode;
        String SubjectName;
        int SubjectHours;

        public Subject(String SubjectCode, String SubjectName, int SubjectHours)
        {
            this.SubjectCode = SubjectCode; 
            this.SubjectName = SubjectName;
            this.SubjectHours = SubjectHours;
        }
        
        public String getSubjectCode()
        {
            return SubjectCode;
        }

        public void setSubjectCode(String SubjectCode)
        {
            this.SubjectCode = SubjectCode;
        }

        public String ToString()
        {
            return (SubjectCode + " " + SubjectName);
        }
    }

