using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Contains answer for each skin care question
/// </summary>
public class AnswerDto
{
	public int QuestionId { get; set; }
	public string Answer { get; set; }
}