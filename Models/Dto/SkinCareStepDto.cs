using System;
namespace GlamCare.Models
{
    /// <summary>
    /// Contains steps for each routine
    /// </summary>
    public class SkinCareStepDto
    {
        public int StepId { get; set; }
        public int StepOrder { get; set; }
        public string Description { get; set; }
        public string TrendyolProductUrl { get; set; }
        public string YouTubeVideoUrl { get; set; }
        public int TotalSteps { get; set; }
    }
}
