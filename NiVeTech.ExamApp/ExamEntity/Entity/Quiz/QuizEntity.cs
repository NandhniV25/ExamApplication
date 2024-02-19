using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEntity.Entity.Quiz
{
    public class QuizEntity
    {
        public int Id { get; set; }
        public string QuizName { get; set; } = string.Empty;
        public string QuizDescription { get; set; } = string.Empty;
    }
}
