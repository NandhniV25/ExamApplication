using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Question
{
    public class QuestionModel
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public int ExamId { get; set; }
        [Required]
        public string Question { get; set; }
    }
}
