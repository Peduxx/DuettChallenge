namespace DuettChallenge.Business.Entities.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
