namespace CompanyOOP.Validators;

public class AgeValidator
{
    public void ValidateAge(int age)
    {
        ValidateNotNegative(age);
        ValidateMinAge(age);
        ValidateMaxAge(age);
        
    }
    private void ValidateMinAge(int age)
    {
        if(age < 18)
            throw new Exception("Age must be equal or greater than 18");
    }

    private void ValidateMaxAge(int age)
    {
        if(age > 120)
            throw new Exception("Age too high, max age is 120");
    }
    
    private void ValidateNotNegative(int age)
    {
        if(age < 0)
            throw new Exception("Age must be greater than 0");
    }
}