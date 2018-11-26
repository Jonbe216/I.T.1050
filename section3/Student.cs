
namespace section3
{
    public class Student
    {
        private int Grade;

        public int GetGrade()
        {
            return this.Grade;
        
        }

        public void Setgrade(int grade)
        {
            this.Grade = grade;
        }

        public string Name { get; set; }
        public Instructor Teacher { get; set; }

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;
        }
        
        public void PrintStudentInfo()
        {
            System.Console.WriteLine("Student: " + this.Name);
            System.Console.WriteLine("Grade: " + this.Grade);
            Teacher.PrintInstructorInfo();
            

        }


    }
}
