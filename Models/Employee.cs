using CompanyOOP.Validators;
namespace CompanyOOP.Models;

public abstract class IEmployee
{
    public abstract void AskForPromotion();
}
public class Employee(string name, string company, int age) : IEmployee {
    private string Name { get; set; } = name;
    private string Company { get; set; } = company;
    private int Age { get; set; } = age;
    
    private readonly AgeValidator _ageValidator = new AgeValidator();
    private readonly NameValidator _nameValidator = new NameValidator();

    
    public override void AskForPromotion()
    {
        if(Age < 30)
        throw new Exception($"Sorry {Name}, you didnt get a promotion cause you are still young");
        Console.WriteLine($"Congratulations {Name}, you got a promotion");
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        _nameValidator.ValidateName(name);
        Name = name;
    }

    public string GetCompany()
    {
        return Company;
    }

    public void SetCompany(string company)
    {
        Company = company;
    }

    public int GetAge()
    {
        return Age;
    }

    public void SetAge(int age)
    {
        _ageValidator.ValidateAge(age);
        Age = age;
    }

    public void work()
    {
        Console.WriteLine($"{Name} is working at {Company}, as a {GetType().Name}");
    }

    void IntroduceYourself() {
        Console.WriteLine($"Hi, I'm {Name}, i have {Age} years and I work at {Company}");
    }
}