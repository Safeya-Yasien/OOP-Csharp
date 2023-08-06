
    class Department
    {
        String DeptCode;
        String DeptName;
        
        public Department(String DeptCode, String DeptName)
        {
            this.DeptCode = DeptCode;
            this.DeptName = DeptName;
        }
        
        public void setDeptCode(String DeptCode)
        {
            this.DeptCode = DeptCode;
        }
        
        public String getDeptCode()
        {
            return (DeptCode);
        }
        
        public void setDeptName(String DeptName)
        {
            this.DeptName = DeptName;
        }
        
        public String getDeptName()
        {
            return (DeptName);
        }

    }
