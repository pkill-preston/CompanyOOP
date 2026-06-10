using System.Text.RegularExpressions;

namespace CompanyOOP.Validators;

public class NameValidator
{
    public void ValidateName(string name)
    {
        ValidateNameMinLength(name);
        ValidateSpecialChar(name);
        ValidateNameMaxLength(name);
    }
    
    private void ValidateNameMinLength(string name)
    {
        if(name.Length < 3)
            throw new Exception("Name must be at least 3 characters long");
    }

    private void ValidateSpecialChar(string name)
    {
        if (!Regex.IsMatch(name, "^[A-Za-z]+$"))
            throw new ArgumentException("Name must contain only letters");
    }

    private void ValidateNameMaxLength(string name)
    {
        if(name.Length > 100)
            throw new Exception("Name must be at most 100 characters long");   
    }
}