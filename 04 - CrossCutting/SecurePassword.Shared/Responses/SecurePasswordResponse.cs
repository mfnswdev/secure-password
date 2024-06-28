namespace SecurePassword.Shared;

public record class SecurePasswordResponse
{
    public List<string> Failures { get; set; } = new List<string>();
}
