using CollegeApp.Model;

namespace CollegeApp
{
    internal class Program
    {
        static void Main()
        {
            
            College college = new College();

       
            Department department1 = new Department(001, "Computer Science");
            Department department2 = new Department(002, "Physics");
            college.Departments.Add(department1);
            college.Departments.Add(department2);

       
            Proffessor professorA = new Proffessor(101, "Professor A");
            Proffessor professorB = new Proffessor(102, "Professor B");
            college.Professors.Add(professorA);
            college.Professors.Add(professorB);

            Student student1 = new Student(201, "Joshit Rejimon");
            Student student2 = new Student(202, "Albin ");
            college.Students.Add(student1);
            college.Students.Add(student2);

            // Display college details
            college.DisplayCollegeDetails();
        }
    }
}