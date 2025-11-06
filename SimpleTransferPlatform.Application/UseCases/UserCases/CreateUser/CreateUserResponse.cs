namespace SimpleTransferPlatform.Application.UseCases.UserCases.CreateUser;

public sealed record CreateUserResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}