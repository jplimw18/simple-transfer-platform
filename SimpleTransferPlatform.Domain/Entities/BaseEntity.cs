namespace SimpleTransferPlatform.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTimeOffset DateCreated { get; private set; }
        public DateTimeOffset? DateModified { get; private set; }
        public DateTimeOffset? DateDeleted { get; private set; }


        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTimeOffset.Now;
        }
    }
}
