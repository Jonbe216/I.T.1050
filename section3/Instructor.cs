

namespace section3
{
    public class Instructor
    {

        public string Name { get; set; }
        
        public string CourseName { get; set; }

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.Setgrade(Grade);
        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine("Instructor: " + this.Name);
            System.Console.WriteLine("Course Name: " + this.CourseName);
            System.Console.WriteLine();


        }
    }
}
