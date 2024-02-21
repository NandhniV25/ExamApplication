using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Question
{
    public class CreateQuestionModel
    {
        [Required]
        public int ExamId { get; set; }
        [Required]
        public string Question { get; set; }

    }
}
