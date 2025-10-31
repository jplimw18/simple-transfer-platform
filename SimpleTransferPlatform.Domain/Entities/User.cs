namespace SimpleTransferPlatform.Domain.Entities
{
    public abstract class User : BaseEntity
    {
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}
