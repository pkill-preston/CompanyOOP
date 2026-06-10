namespace CompanyOOP.Models;

public class Teacher(string name, string company, int age, string subject) : Employee(name, company, age)
{
    public string Subject { get; } = subject;

    public void FixBug()
    {
        Console.WriteLine($"{name} is fixing a bug, using {subject}");
    }
    
    public void work()
    {
        Console.WriteLine($"{name} is working at {company}, as a {GetType().Name} teaching lessons about {subject}");
    }
}