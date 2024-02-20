using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamEntity.Entity.Exam
{
    public class ExamEntity
    {
        public int Id { get; set; }
        public string ExamName { get; set; } = string.Empty;
        public string ExamDescription { get; set; } = string.Empty;
    }
}
