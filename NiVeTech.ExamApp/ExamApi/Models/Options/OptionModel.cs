using System.ComponentModel.DataAnnotations;

namespace NiVeTech.ExamApi.Models.Options
{
    public class OptionModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int questionId { get; set; }
        [Required]
        public string option { get; set; }
    }
}
