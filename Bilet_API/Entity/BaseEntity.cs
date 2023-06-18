namespace Bilet_API.Entity
{
    public abstract class BaseEntity
    {
        public DateTime? AddDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
