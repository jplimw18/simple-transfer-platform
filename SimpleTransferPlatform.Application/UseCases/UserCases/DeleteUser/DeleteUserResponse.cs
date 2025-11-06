namespace SimpleTransferPlatform.Application.UseCases.UserCases.DeleteUser;

public sealed record DeleteUserResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateDeleted { get; set; }
}