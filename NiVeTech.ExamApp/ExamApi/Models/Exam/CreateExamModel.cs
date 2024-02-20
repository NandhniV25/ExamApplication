using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Exam
{
    public class CreateExamModel
    {
        [Required]
        public string ExamName { get; set; } = string.Empty;
        [Required]
        public string ExamDescription { get; set;} = string.Empty;
    }
}
