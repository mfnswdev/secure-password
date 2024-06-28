
namespace SecurePassword.Domain;

public class PasswordHandler : IPasswordHandler
{

    public List<string> validatePass(string pass)
    {
        List<string> failures = new List<string>();

        validateLength(pass, failures);
        validateUppercase(pass, failures);
        validateLowercase(pass, failures);
        validateNumber(pass, failures);
        validateSpecialChar(pass, failures);


        return failures;
    }
    private static void validateLength(string pass, List<string> failures)
    {
        if (pass == null || pass.Length < 8)
        {
            failures.Add("Password must be at least 8 characters");
        }
    }
    private static void validateUppercase(string pass, List<string> failures)
    {
        if (!pass.Any(char.IsUpper))
        {
            failures.Add("Password must contain at least one uppercase character");
        }
    }
    private static void validateLowercase(string pass, List<string> failures)
    {
        if (!pass.Any(char.IsLower))
        {
            failures.Add("Password must contain at least one lowercase character");
        }
    }
    private static void validateNumber(string pass, List<string> failures)
    {
        if (!pass.Any(char.IsNumber))
        {
            failures.Add("Password must contain at least one number");
        }
    }
    private static void validateSpecialChar(string pass, List<string> failures)
    {
        if (!pass.Any(c => !char.IsLetterOrDigit(c)))
        {
            failures.Add("Password must contain at least one special character");
        }
    }

}
