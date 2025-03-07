using GlamCare.Models;
using System;

namespace GlamCare.Models
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Routine : BaseModel
    {
        public int UserId { get; set; }
        public SkinType SkinType { get; set; }

        public User User { get; set; }
        public ICollection<SkinCareStep> Steps { get; set; }
    }
}