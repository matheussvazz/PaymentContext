namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}