using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Exam
{
    public class ExamModel
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string ExamName { get; set; } = string.Empty;
        [Required]
        public string ExamDescription { get; set; } = string.Empty;
    }
}
