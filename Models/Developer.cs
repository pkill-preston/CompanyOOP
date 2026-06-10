namespace CompanyOOP.Models;

class Developer(string name, string company, int age, string language) : Employee(name, company, age)
{
    public string Language { get; } = language;

    public void FixBug()
    {
        Console.WriteLine($"{name} is fixing a bug, using {language}");
    }
    public void work()
    {
        Console.WriteLine($"{name} is working at {company}, as a {GetType().Name} fixing bugs and developing new features");
    }
}