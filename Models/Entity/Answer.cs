using GlamCare.Models;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Answer : BaseModel
{
    public int QuestionId { get; set; }
    public string AnswerText { get; set; }
    public int UserId { get; set; }

    public Question Question { get; set; }
    public User User { get; set; }
}
