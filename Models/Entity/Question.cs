using GlamCare.Models;
using System;
namespace GlamCare.Models
{
    /// <summary>
    /// Questions to be asked to obtain skin type
    /// </summary>
    public class Question : BaseModel
    {
        public string QuestionText { get; set; }
    }
}
