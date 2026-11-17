
using System;

class Course
{
    public string Code { get; init; }
    public string Name { get; set; }

    private int credits;

    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10)
                credits = value;
            else
                Console.WriteLine("Credits must be between 1 and 10!");
        }
    }

    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public string Info()
    {
        return $"{Code} {Name} ({Credits} cr)";
    }
}

class Program
{
    static void Main()
    {
        Course[] courses = new Course[5];

        courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
        courses[1] = new Course("CENG201", "Data Structures", 5);
        courses[2] = new Course("MATH201", "Mathematics", 3);
        courses[3] = new Course("PHYS201", "Physics", 4);
        courses[4] = new Course("ENG201", "English", 2);

        int totalCredits = 0;

        Console.WriteLine("Course List:");

        foreach (Course course in courses)
        {
            Console.WriteLine(course.Info());
            totalCredits += course.Credits;
        }

        Console.WriteLine("\nTotal Credits: " + totalCredits);

        string[] courseNames = new string[courses.Length];

        for (int i = 0; i < courses.Length; i++)
        {
            courseNames[i] = courses[i].Name;
        }

        Array.Sort(courseNames);

        Console.WriteLine("\nCourses in Alphabetical Order:");

        foreach (string name in courseNames)
        {
            Console.WriteLine(name);
        }
    }
}

