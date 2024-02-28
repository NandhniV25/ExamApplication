using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Options
{
    public class CreateOptionModel
    {
        [Required]
        public int questionId { get; set; }
        [Required]
        public string option { get; set; }
    }
}
