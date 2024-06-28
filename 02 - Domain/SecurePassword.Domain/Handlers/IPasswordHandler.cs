namespace SecurePassword.Domain;

public interface IPasswordHandler
{
    List<string> validatePass(string pass);
}
