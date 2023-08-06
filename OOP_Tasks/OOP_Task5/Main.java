import java.time.LocalDateTime;

class Program
{
    static void Main(String[] args)
    {
        Student s1 = new Student("123456", "ahemd");
        Student s2 = new Student("7891011", "mohamed");
        System.out.println(s1.getCode() + "\n" + s2.getCode());

        Subject sub1 = new Subject("IT01", "Digital", 3);
        // System.out.println(sub1.toString());
        Subject sub2 = new Subject("CS02", "Image", 3);
        Subject sub3 = new Subject("IT11", "Computer", 3);
        Subject sub4 = new Subject("IS20", "Processing", 3);

        Subject[] subgroup1 = { sub1, sub2 };
        Subject[] subgroup2 = { sub3, sub4 };

        s1.setSubjects(subgroup1);
        s2.setSubjects(subgroup2);

        System.out.println(s1.getSubjects().length);

        s1.addSubject(sub3);
        s1.addSubject(sub4);

        System.out.println(s1.getSubjects().length);

        System.out.println(s1.getSubjects()[3].toString());

        System.out.println(s1.getTotalHours());

        LocalDateTime dt = LocalDateTime.of(2023, 8, 1, 0, 0);
        Doctor d1 = new Doctor("1010", "Sameh", dt);

        Student st3 = new Student("011", "Mona");
        st3.setSupervisor(d1);

        Department dept1 = new Department("5555", "CS");
        st3.setDpt(dept1);

        d1.setDept(dept1);

    }
}

