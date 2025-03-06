namespace GlamCare.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime RecordDate { get; set; }
        public int RecordedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
