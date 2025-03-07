using GlamCare.Models;
using System;

namespace GlamCare.Models
{
    /// <summary>
    /// Contains steps for each routine
    /// </summary>
    public class SkinCareStep : BaseModel
    {
        public int RoutineId { get; set; }
        public int StepOrder { get; set; }
        public string Description { get; set; }
        public string TrendyolProductUrl { get; set; }
        public string YouTubeVideoUrl { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Routine Routine { get; set; }
    }
}