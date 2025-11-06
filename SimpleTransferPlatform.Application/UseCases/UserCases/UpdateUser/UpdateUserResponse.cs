namespace SimpleTransferPlatform.Application.UseCases.UserCases.UpdateUser;

public sealed record UpdateUserResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset DateModified { get; set; }
}