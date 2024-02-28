using NiVeTech.ExamEntity.Entity.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamEntity.Entity.Question
{
    public class QuestionEntity
    {
        public int Id { get; set; }
        public NiVeTech.ExamEntity.Entity.Exam.ExamEntity Exam { get; set; }
        public int ExamId { get; set; }
        public string Question { get; set; }
    }
}
