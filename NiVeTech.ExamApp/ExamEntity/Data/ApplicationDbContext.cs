using NiVeTech.ExamEntity.Entity.Exam;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamEntity.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<NiVeTech.ExamEntity.Entity.Exam.ExamEntity> Exams { get; set; }
        public DbSet<NiVeTech.ExamEntity.Entity.Question.QuestionEntity> Questions { get; set; }
    }
}
