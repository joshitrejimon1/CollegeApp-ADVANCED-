using CollegeApp.Model;

class College
{
    public List<Proffessor> Professors { get; set; }
    public List<Student> Students { get; set; }
    public List<Department> Departments { get; set; }


    public College()
    {
        Professors = new List<Proffessor>();
        Students = new List<Student>();
        Departments = new List<Department>();
    }

    public void DisplayCollegeDetails()
    {


        Console.WriteLine("=======================================================");
        Console.WriteLine("                  College Details:--");
        Console.WriteLine("=======================================================");
        Console.WriteLine("\nDepartments:");




        foreach (var department in Departments)
        {
            Console.WriteLine($"Department Id: {department.Id}, Department Name: {department.Name}");
        }
        Console.WriteLine("\nProfessors:");
        foreach (var professor in Professors)
        {
            Console.WriteLine($"Professor Id: {professor.Id}, Professor Name: {professor.Name}");
        }
        Console.WriteLine("\nStudents:");
        foreach (var student in Students)
        {
            Console.WriteLine($"Student Id: {student.Id}, Student Name: {student.Name}");
        }
    }
}
