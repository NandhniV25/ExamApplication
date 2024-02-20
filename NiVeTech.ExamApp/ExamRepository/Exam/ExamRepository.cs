using NiVeTech.ExamEntity.Entity.Exam;
using NiVeTech.ExamEntity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepository.Quiz
{
    public class ExamRepository : IExamRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ExamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateQuiz(NiVeTech.ExamEntity.Entity.Exam.ExamEntity quiz)
        {
            _dbContext.Exams.Add(quiz);
            _dbContext.SaveChanges();
            return quiz.Id;
        }

        public List<NiVeTech.ExamEntity.Entity.Exam.ExamEntity> GetAll()
        {
            return _dbContext.Exams.ToList();
        }

        public NiVeTech.ExamEntity.Entity.Exam.ExamEntity GetQuizById(int id)
        {
            return _dbContext.Exams.FirstOrDefault(c => c.Id == id);
        }
    }
}
