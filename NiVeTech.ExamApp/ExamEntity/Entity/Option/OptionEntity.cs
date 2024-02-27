using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using NiVeTech.ExamEntity.Entity.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamEntity.Entity.Option
{
    public class OptionEntity
    {
        public int Id { get; set; } 
        public QuestionEntity Question { get; set; }
        public int QuestionId { get; set; }
        public string Option { get; set; }
    }
}
