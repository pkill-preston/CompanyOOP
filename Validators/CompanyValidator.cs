namespace CompanyOOP.Validators;

public class CompanyValidator
{
    public void ValidateCompany(string company)
    {
        ValidateCompanyMinLength(company);
        ValidateCompanyMaxLength(company);
    }
    
    private void ValidateCompanyMinLength(string company)
    {
        if(company.Length < 2)
            throw new Exception("Name must be at least 2 characters long");
    }
    
    private void ValidateCompanyMaxLength(string company)
    {
        if(company.Length > 100)
            throw new Exception("Company name must be at most 100 characters long");
    }
}