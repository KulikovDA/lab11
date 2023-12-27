// Базовый 23
class Student
{
    private string lastName;
    private double averageScore;
    private int course;

    public Student(string lastName, double averageScore, int course)
    {
        this.lastName = lastName;
        this.averageScore = averageScore;
        this.course = course;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public double GetAverageScore()
    {
        return averageScore;
    }

    public int GetCourse()
    {
        return course;
    }

    public double CalculateQuality()
    {
        return 0.2 * averageScore * course;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Фамилия: " + lastName);
        Console.WriteLine("Средний балл: " + averageScore);
        Console.WriteLine("Курс: " + course);
        Console.WriteLine("Качество: " + CalculateQuality());
    }
}

class SubStudent : Student
{
    private bool P;

    public SubStudent(string lastName, double averageScore, int course, bool P) : base(lastName, averageScore, course)
    {
        this.P = P;
    }

    public new double CalculateQuality()
    {
        if (P)
        {
            return 2 * base.CalculateQuality();
        }
        else
        {
            return 0.9 * base.CalculateQuality();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Иванов", 4.5, 3);
        SubStudent student2 = new SubStudent("Петров", 4.8, 4, true);
        SubStudent student3 = new SubStudent("Сидоров", 3.7, 2, false);

        student1.PrintInfo();
        student2.PrintInfo();
        student3.PrintInfo();
    }
}